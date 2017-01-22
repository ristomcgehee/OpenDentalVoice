using OpenDental;
using System.Windows.Forms;

namespace VoiceCommand {
	public partial class VoiceMsgBox {
		private class VoiceMsgBoxSpeech:VoiceCommandAbs {
			private FormMsgBox _formMsgBoxVoice;

			public VoiceMsgBoxSpeech(FormMsgBox formMsgBox) {
				_formMsgBoxVoice=formMsgBox;
				InitializeListening(includeGlobal:false);
				IsListening=true;
			}

			protected override VoiceCommandArea ProgramArea {
				get {
					return VoiceCommandArea.VoiceMsgBox;
				}
			}
			protected override void ExecuteVoiceCommand(VoiceCommandAction action) {
				base.ExecuteVoiceCommand(action);
				switch(action) {
					case VoiceCommandAction.Ok:
					case VoiceCommandAction.Yes:
						_formMsgBoxVoice.DialogResult=DialogResult.OK;
						break;
					case VoiceCommandAction.Cancel:
					case VoiceCommandAction.No:
						_formMsgBoxVoice.DialogResult=DialogResult.Cancel;
						break;
					default:
						return;
				}
				_formMsgBoxVoice.Close();
			}

			public void SayText() {
				SayResponseAsync(_formMsgBoxVoice.MessageText);
			}
		}
		private FormMsgBox _formMsgBox;
		
		///<summary>Displays a message box with the text and reads the text aloud. The user can respond by clicking buttons or answering by voice.</summary>
		public static bool Show(string text,MsgBoxButtons buttons) {
			VoiceMsgBox voiceBox=new VoiceMsgBox();
			voiceBox._formMsgBox=new FormMsgBox(text,buttons);
			VoiceMsgBoxSpeech voiceBoxSpeech=new VoiceMsgBoxSpeech(voiceBox._formMsgBox);
			voiceBoxSpeech.SayText();
			voiceBox._formMsgBox.ShowDialog();
			voiceBoxSpeech.Dispose();
			if(voiceBox._formMsgBox.DialogResult==DialogResult.OK) {
				return true;
			}
			return false;
		}
		
	}
}
