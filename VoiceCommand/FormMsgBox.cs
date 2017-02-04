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
using System;
using System.Windows.Forms;

namespace VoiceCommand {
	public partial class FormMsgBox:Form {
		public string MessageText;
		private MsgBoxButtons _buttons;

		public FormMsgBox(string text,MsgBoxButtons buttons) {
			InitializeComponent();
			MessageText=text;
			_buttons=buttons;
		}

		private void FormMsgBox_Load(object sender,EventArgs e) {
			labelText.Text=MessageText;
			//add resizing later
			if (_buttons==MsgBoxButtons.YesNo) {
				butOK.Text="&Yes";
				butCancel.Text="&No";
			}
		}

		private void butOK_Click(object sender,EventArgs e) {
			DialogResult=DialogResult.OK;
		}

		private void butCancel_Click(object sender,EventArgs e) {
			DialogResult=DialogResult.Cancel;
		}
	}
}
