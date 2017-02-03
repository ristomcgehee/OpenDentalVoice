using OpenDental;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceCommand {
	public abstract class VoiceCommandAbs:IDisposable {
		private SpeechRecognitionEngine _recEngine=new SpeechRecognitionEngine();
		private SpeechSynthesizer _synth=new SpeechSynthesizer();
		protected abstract VoiceCommandArea ProgramArea { get; }
		protected bool IsListening {
			get {
				return _isListening;
			}
			set {
				_isListening=value;
				if(labelListening != null) {
					labelListening.Visible=value;
				}
			}
		}
		protected bool IsGivingFeedback=true;
		private Label labelListening;
		private bool _isListening;
		private bool _initializationFailed;
		
		public virtual void InitializeListening(bool includeGlobal=true) {
			Choices commandChoices=new Choices();
			commandChoices.Add(CommandList.Commands.Where(x => x.Area==ProgramArea || (includeGlobal && x.Area==VoiceCommandArea.Global))
				.SelectMany(x => x.Commands).ToArray());
			try {
				// Create a GrammarBuilder object and append the Choices object.
				GrammarBuilder gb=new GrammarBuilder();
				gb.Append(commandChoices);
				// Create the Grammar instance and load it into the speech recognition engine.
				Grammar g=new Grammar(gb);
				_recEngine=new SpeechRecognitionEngine();
				_recEngine.LoadGrammarAsync(g);
				_recEngine.SetInputToDefaultAudioDevice();
				_recEngine.RecognizeAsync(RecognizeMode.Multiple);
				_recEngine.SpeechRecognized+=RecEngine_SpeechRecognized;
				_synth.SetOutputToDefaultAudioDevice();
				_synth.SelectVoiceByHints(VoiceGender.Female);
			}
			catch {
				_initializationFailed=true;
			}
		}

		protected virtual void RecEngine_SpeechRecognized(object sender,SpeechRecognizedEventArgs e) {
			VoiceCommand voiceCommand=CommandList.Commands.FirstOrDefault(x => x.Commands.Contains(e.Result.Text));
			if(voiceCommand==null) {
				return;
			}
			if(e.Result.Confidence<0.8) {
				voiceCommand.Action=VoiceCommandAction.DidntGetThat;
			}
			if(voiceCommand.Action==VoiceCommandAction.StartListening) {
				IsListening=true;
				SayResponse("listening");
			}
			if(voiceCommand.Action==VoiceCommandAction.StopListening) {
				SayResponse("good-bye");
				IsListening=false;
			}
			if(!IsListening) {
				return;
			}
			ExecuteVoiceCommand(voiceCommand.Action);
		}

		protected virtual void ExecuteVoiceCommand(VoiceCommandAction action) {
			string response="";
			switch(action) {
				case VoiceCommandAction.GiveFeedback:
					IsGivingFeedback=true;
					response="Giving feedback";
					break;
				case VoiceCommandAction.StopGivingFeedback:
					IsGivingFeedback=false;
					response="No longer giving feedback";
					_synth.Speak(response);
					break;
				case VoiceCommandAction.DidntGetThat:
					response="I didn't get that.";
					break;
			}
			SayResponse(response);
		}

		protected void SayResponse(string response,int pauseBefore=0) {
			if(!string.IsNullOrEmpty(response) && IsGivingFeedback) {
				Thread.Sleep(pauseBefore);
				_isListening=false;
				_synth.Speak(response);
				Thread.Sleep(10);//So that it doesn't take in the response as human speech
				_isListening=true;
			}
		}

		protected void SayResponseAsync(string response) {
			if (!string.IsNullOrEmpty(response) && IsGivingFeedback) {
				_isListening=false;
				_synth.SpeakAsync(response);
				Thread.Sleep(10);//So that it doesn't take in the response as human speech
				_isListening=true;
			}
		}

		protected virtual void AddMicButton(Control control,Point point) {
			OpenDental.UI.Button butMic=new OpenDental.UI.Button();
			butMic.Image=Properties.Resources.Mic_30px;
			butMic.ImageAlign=ContentAlignment.MiddleCenter;
			butMic.Location=point;
			butMic.Size=new Size(34,34);
			butMic.Click+=butMic_Click;
			control.Controls.Add(butMic);
			labelListening=new Label();
			labelListening.Text="Listening";
			labelListening.ForeColor=Color.LimeGreen;
			labelListening.Location=new Point(point.X+36,point.Y+10);
			labelListening.Visible=false;
			control.Controls.Add(labelListening);
			OpenDental.UI.Button butHelp=new OpenDental.UI.Button();
			butHelp.Image=Properties.Resources.Help_18px;
			butHelp.ImageAlign=ContentAlignment.MiddleCenter;
			butHelp.Location=new Point(point.X+3,point.Y+37);
			butHelp.Size=new Size(18,18);
			butHelp.Click+=butHelp_Click;
			control.Controls.Add(butHelp);
		}

		private void butHelp_Click(object sender,EventArgs e) {
			FormHelp FormH=new FormHelp(CommandList.Commands.Where(x => x.Area==ProgramArea||x.Area==VoiceCommandArea.Global)
				.SelectMany(x => x.Commands).ToList());
			FormH.Show();
		}

		protected void butMic_Click(object sender,EventArgs e) {
			if(_initializationFailed) {
				MessageBox.Show("This computer's audio input is not capable of speech recognition. Try setting up a different microphone on this computer.");
				return;
			}
			IsListening=!IsListening;
		}

		public void Dispose() {
			_recEngine.Dispose();
			_synth.Dispose();
		}
	}
}
