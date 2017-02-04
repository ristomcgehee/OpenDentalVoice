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
using System;
using OpenDentBusiness;
using OpenDental;

namespace VoiceCommand {//The namespace for this class must match the dll filename, including capitalization.  All other classes will typically belong to the same namespace too, but that's not a requirement.
	/// <summary>Required class.  Don't change the name.</summary>
	public class Plugin : PluginBase {
		private static FormPerioV _formPerioV;
		
		public override bool HookAddCode(object sender,string hookName,params object[] parameters) {//required method
			switch(hookName) {
				case "FormPerio.Load_end":
					_formPerioV=new FormPerioV((FormPerio)sender);
					_formPerioV.InitializeListening();
					return true;
				case "FormPerio.Closing_end":
					_formPerioV?.Dispose();
					return true;
				default:
					return false;
			}
		}

		public override void HookException(Exception e) {
			Logging.LogException(e);
			MsgBox.Show(LanThis,"There was an error with the Voice Command plugin.");
		}

		public static string LanThis="VoiceCommandPlugin";
	}
}

