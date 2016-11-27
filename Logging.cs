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