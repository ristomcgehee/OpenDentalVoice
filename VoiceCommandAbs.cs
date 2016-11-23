using OpenDental;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceCommand {
	public abstract class VoiceCommandAbs {
		protected static SpeechRecognitionEngine RecEngine=new SpeechRecognitionEngine();
		protected abstract VoiceCommandArea ProgramArea { get; }
		protected bool IsListening;
		
		public virtual void InitializeListening() {
			Choices commands=new Choices();
			commands.Add(CommandList.Commands.Where(x => x.Area==ProgramArea || x.Area==VoiceCommandArea.Global)
				.SelectMany(x => x.Commands).ToArray());
			// Create a GrammarBuilder object and append the Choices object.
			GrammarBuilder gb=new GrammarBuilder();
			gb.Append(commands);
			// Create the Grammar instance and load it into the speech recognition engine.
			Grammar g=new Grammar(gb);
			RecEngine=new SpeechRecognitionEngine();
			RecEngine.LoadGrammarAsync(g);
			RecEngine.SetInputToDefaultAudioDevice();
			RecEngine.RecognizeAsync(RecognizeMode.Multiple);
			RecEngine.SpeechRecognized+=RecEngine_SpeechRecognized;
		}

		protected virtual void RecEngine_SpeechRecognized(object sender,SpeechRecognizedEventArgs e) {
			VoiceCommand voiceCommand=CommandList.Commands.FirstOrDefault(x => x.Commands.Contains(e.Result.Text));
			if(voiceCommand==null) {
				MsgBox.Show("VoicePlugin","Command not recognized");
				return;
			}
			if(voiceCommand.Action==VoiceCommandAction.StartListening) {
				IsListening=true;
			}
			if(voiceCommand.Action==VoiceCommandAction.StopListening) {
				IsListening=false;
			}
			if(!IsListening) {
				return;
			}
			ExecuteVoiceCommand(voiceCommand.Action);
		}

		protected virtual void ExecuteVoiceCommand(VoiceCommandAction action) {	}

		protected virtual void AddMicButton(Control control,Point point) {
			OpenDental.UI.Button butMic=new OpenDental.UI.Button();
			butMic.Image=Properties.Resources.Mic_30px;
			butMic.ImageAlign=ContentAlignment.MiddleCenter;
			butMic.Location=point;
			butMic.Size=new Size(34,34);
			butMic.Click+=butMic_Click;
			control.Controls.Add(butMic);
		}

		protected void butMic_Click(object sender,EventArgs e) {
			IsListening=!IsListening;
		}
	}
}
