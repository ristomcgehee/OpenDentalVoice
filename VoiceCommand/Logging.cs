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
using System.IO;

namespace VoiceCommand {
	internal class Logging {
		public static string LogDirectory="VoiceCommandLogs";

		internal static void LogException(Exception e) {
			string errorText = "Error Message: "+e.Message+"\r\nStack Trace:\r\n"+e.StackTrace+"\r\nTime of Occurrence: "+DateTime.Now
				+"\r\n-----------------------------------------------------------------------------------------\r\n";
			try {
				if(!Directory.Exists(LogDirectory)) {
					Directory.CreateDirectory(LogDirectory);
				}
				string path=LogDirectory+"//"+DateTime.Today.ToString("dd-MM-yyyy")+".log";
				File.AppendAllText(path,errorText);
			}
			catch {
				//Do nothing
			}
		}
	}
}