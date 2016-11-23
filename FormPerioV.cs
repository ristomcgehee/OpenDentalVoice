using OpenDental;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VoiceCommand {
	public class FormPerioV:VoiceCommandAbs {
		private FormPerio _formPerio;
		protected override VoiceCommandArea ProgramArea {
			get {
				return VoiceCommandArea.PerioChart;
			}
		}

		public FormPerioV(FormPerio sender) { 
			_formPerio=sender;
			AddMicButton(_formPerio,new Point(12,300));
		}
		
		protected override void ExecuteVoiceCommand(VoiceCommandAction action) {
			switch(action) {
				case VoiceCommandAction.CreatePerioChart:
					OpenDental.UI.Button but=(OpenDental.UI.Button)_formPerio.Controls.Find("butAdd",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Zero:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but0",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.One:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but1",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Two:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but2",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Three:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but3",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Four:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but4",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Five:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but5",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Six:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but6",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Seven:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but7",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Eight:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but8",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Nine:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but9",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Ten:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but0",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Eleven:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but1",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Twelve:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but2",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Thirteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but3",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Fourteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but4",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Fifteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but5",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Sixteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but6",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Seventeen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but7",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Eightteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but8",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Nineteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but9",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Triplet:
					CheckBox checkThree=(CheckBox)_formPerio.Controls.Find("checkThree",true)[0];
					checkThree.Checked=(!checkThree.Checked);
					MethodInfo dynMethod=_formPerio.GetType().GetMethod("checkThree_Click",
					BindingFlags.NonPublic|BindingFlags.Instance);
					dynMethod.Invoke(_formPerio,new object[] { _formPerio,new EventArgs() });
					break;
				case VoiceCommandAction.Bleeding:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butBleed",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Plaque:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butPlaque",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Calculus:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butCalculus",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Suppuration:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butPus",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Backspace:
					SendKeys.Send("{BACKSPACE}");
					break;
				case VoiceCommandAction.Skip:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butSkip",true)[0];
					but.PerformClick();
					break;
				case VoiceCommandAction.Right:
						SendKeys.Send("{RIGHT}");
					break;
				case VoiceCommandAction.Left:
					SendKeys.Send("{LEFT}");
					break;
				case VoiceCommandAction.Delete:
					SendKeys.Send("{DELETE}");
					break;
				case VoiceCommandAction.CopyPrevious:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butCopyPrevious",true)[0];
					but.PerformClick();
					break;
				default:
					break;
			}
		}
	}
}
