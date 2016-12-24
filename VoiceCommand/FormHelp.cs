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
	public partial class FormHelp:Form {
		private List<string> _listCommands;

		public FormHelp(List<string> listCommands) {
			InitializeComponent();
			_listCommands=listCommands;
		}

		private void FormHelp_Load(object sender,EventArgs e) {
			labelCommandList.Text="-"+string.Join("\r\n-",_listCommands);
		}
	}
}
