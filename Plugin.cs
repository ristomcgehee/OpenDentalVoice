using System;
using OpenDentBusiness;
using OpenDental;

namespace VoiceCommand {//The namespace for this class must match the dll filename, including capitalization.  All other classes will typically belong to the same namespace too, but that's not a requirement.
	/// <summary>Required class.  Don't change the name.</summary>
	public class Plugin : PluginBase {
		
		public override bool HookAddCode(object sender,string hookName,params object[] parameters) {//required method
			switch(hookName) {
				case "FormPerio.Load_end":
					new FormPerioV((FormPerio)sender).InitializeListening();
					return true;
				default:
					return false;
			}
		}

		public override void HookException(Exception e) {
			Logging.LogException(e);
			MsgBox.Show(LanThis,"There was an error with the Voice Command plugin. Please update to the newest version.");
		}

		public static string LanThis="VoiceCommandPlugin";
	}
}

