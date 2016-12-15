using OpenDentBusiness;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace VoiceCommandInstaller {
	public partial class FormInstall : Form {
		public FormInstall() {
			InitializeComponent();
		}
		
		private void FormInstall_Load(object sender,EventArgs e) {
			if(Directory.Exists(@"C:\Program Files (x86)\Open Dental")) {
				textDir.Text=@"C:\Program Files (x86)\Open Dental";
			}
			else if(Directory.Exists(@"C:\Program Files\Open Dental")) {
				textDir.Text=@"C:\Program Files\Open Dental";
			}
			butInstall.Select();
		}

		private void butBrowse_Click(object sender,EventArgs e) {
			FolderBrowserDialog folderBrowser=new FolderBrowserDialog();
			folderBrowser.RootFolder=Environment.SpecialFolder.ProgramFilesX86;
			folderBrowser.ShowNewFolderButton=false;
			if(folderBrowser.ShowDialog()==DialogResult.OK) {
				textDir.Text=folderBrowser.SelectedPath;
			}
		}

		private void CreateProgramLink() {
			if(!checkCreateProgLink.Checked) {
				return;
			}
			XmlDocument document=new XmlDocument();
			document.Load(textDir.Text+"\\FreeDentalConfig.xml");
			XPathNavigator Navigator=document.CreateNavigator();
			XPathNavigator nav;
			//Database type
			nav=Navigator.SelectSingleNode("//DatabaseType");
			DatabaseType dbType=DatabaseType.MySql;
			if(nav != null && nav.Value=="Oracle") {
				dbType=DatabaseType.Oracle;
			}
			//See if there's a DatabaseConnection
			nav=Navigator.SelectSingleNode("//DatabaseConnection");
			string serverName="";
			string databaseName="";
			string userName="";
			string password="";
			if(nav!=null) {
				//If there is a DatabaseConnection, then use it.
				serverName=nav.SelectSingleNode("ComputerName").Value;
				databaseName=nav.SelectSingleNode("Database").Value;
				userName=nav.SelectSingleNode("User").Value;
				password=nav.SelectSingleNode("Password").Value;
				XPathNavigator encryptedPwdNode=nav.SelectSingleNode("MySQLPassHash");
				//If the Password node is empty, but there is a value in the MySQLPassHash node, decrypt the node value and use that instead
				string decryptedPwd;
				if(password==""
					&& encryptedPwdNode!=null
					&& encryptedPwdNode.Value!=""
					&& CDT.Class1.Decrypt(encryptedPwdNode.Value,out decryptedPwd))
				{
					//decrypted value could be an empty string, which means they don't have a password set, so textPassword will be an empty string
					password=decryptedPwd;
				}
			}
			DataConnection dbCon=new DataConnection();
			dbCon.SetDb(serverName,databaseName,userName,password,"","",dbType);
			if(ProgramC.GetListt().Count(x => x.ProgDesc=="Voice Command") > 0) {//Program link already exists
				return;
			}
			OpenDentBusiness.Program prog=new OpenDentBusiness.Program();
			prog.ProgDesc="Voice Command";
			prog.Enabled=true;
			prog.PluginDllName="VoiceCommand.dll";
			Programs.Insert(prog);
		}

		private void butInstall_Click(object sender,EventArgs e) {
			if(textDir.Text=="") {
				MessageBox.Show("Please select the directory where Open Dental is installed.");
				return;
			}
			if(!Directory.Exists(textDir.Text)) {
				MessageBox.Show("Directory does not exist.");
				return;
			}
			try {
				File.Delete(textDir.Text+"\\VoiceCommand.dll");
				File.Copy("VoiceCommand.dll",textDir.Text+"\\VoiceCommand.dll");
			}
			catch {
				MessageBox.Show("Installation unsuccessful. Try running this installer as administrator.");
				return;
			}
			try {
				CreateProgramLink();
			}
			catch {
				MessageBox.Show("Unable to create a Program Link. Enter the Program Link manually inside Open Dental");
			}
			MessageBox.Show("Installation complete.");
			Application.Exit();
		}

		private void butCancel_Click(object sender,EventArgs e) {
			Application.Exit();
		}

	}
}
