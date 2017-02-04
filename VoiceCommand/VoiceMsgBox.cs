/*==================================================================================
This file is a part of Voice Command.
Copyright 2017  Christopher A. McGehee

Voice Command is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Voice Command is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
===================================================================================*/
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
