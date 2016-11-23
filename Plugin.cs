using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using OpenDentBusiness;
using OpenDental;

namespace VoiceCommand {//The namespace for this class must match the dll filename, including capitalization.  All other classes will typically belong to the same namespace too, but that's not a requirement.
	/// <summary>Required class.  Don't change the name.</summary>
	public class Plugin : PluginBase {

		public override bool HookMethod(object sender,string hookName,params object[] parameters) {//required method
			switch(hookName) {				
				default:
					return false;//this plugin does not implement the particular hook passed in.
			}
		}

		public override bool HookAddCode(object sender,string hookName,params object[] parameters) {//required method
			switch(hookName) {
				case "FormPerio.Load_end":
					new FormPerioV((FormPerio)sender).InitializeListening();
					return true;
				default:
					return false;
			}
		}

	}
}

