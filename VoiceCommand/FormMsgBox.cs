using OpenDental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
