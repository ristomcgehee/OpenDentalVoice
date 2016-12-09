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
		private int _curToothNum=1;
		private int _selectedExam {
			get {
				return ((ContrPerio)_formPerio.Controls.Find("gridP",true)[0]).SelectedExam;
			}
		}
		private Point _curCell {
			get {
				ContrPerio contrPerio=(ContrPerio)_formPerio.Controls.Find("gridP",true)[0];
				return (Point)typeof(ContrPerio).GetField("CurCell",BindingFlags.NonPublic|BindingFlags.Instance)
					.GetValue(contrPerio);
			}
			set {
				ContrPerio contrPerio=(ContrPerio)_formPerio.Controls.Find("gridP",true)[0];
				MethodInfo dynMethod=contrPerio.GetType().GetMethod("SetNewCell",
					BindingFlags.NonPublic|BindingFlags.Instance);
				dynMethod.Invoke(contrPerio,new object[] { value.X,value.Y });
			}
		}

		public FormPerioV(FormPerio sender) { 
			_formPerio=sender;
			AddMicButton(_formPerio,new Point(12,300));
#if DEBUG
			IsListening=true;
#endif
		}
		
		protected override void ExecuteVoiceCommand(VoiceCommandAction action) {
			base.ExecuteVoiceCommand(action);
			string response="";
			switch(action) {
				case VoiceCommandAction.CreatePerioChart:
					OpenDental.UI.Button but=(OpenDental.UI.Button)_formPerio.Controls.Find("butAdd",true)[0];
					but.PerformClick();
					response="Adding perio chart. Probing tooth 1.";
					break;
				case VoiceCommandAction.Zero:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but0",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.One:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but1",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Two:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but2",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Three:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but3",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Four:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but4",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Five:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but5",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Six:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but6",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Seven:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but7",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Eight:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but8",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Nine:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but9",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Ten:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but0",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Eleven:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but1",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Twelve:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but2",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Thirteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but3",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Fourteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but4",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Fifteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but5",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Sixteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but6",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Seventeen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but7",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Eightteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but8",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Nineteen:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but10",true)[0];
					but.PerformClick();
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("but9",true)[0];
					but.PerformClick();
					response=action.ToString();
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
					response=action.ToString();
					break;
				case VoiceCommandAction.Plaque:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butPlaque",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Calculus:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butCalculus",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Suppuration:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butPus",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.Backspace:
					SendKeys.Send("{BACKSPACE}");
					response=action.ToString();
					break;
				case VoiceCommandAction.SkipToTooth:
					//but=(OpenDental.UI.Button)_formPerio.Controls.Find("butSkip",true)[0];
					//but.PerformClick();
					break;
				case VoiceCommandAction.Right:
						SendKeys.Send("{RIGHT}");
					response=action.ToString();
					break;
				case VoiceCommandAction.Left:
					SendKeys.Send("{LEFT}");
					response=action.ToString();
					break;
				case VoiceCommandAction.Delete:
					SendKeys.Send("{DELETE}");
					response=action.ToString();
					break;
				case VoiceCommandAction.CopyPrevious:
					but=(OpenDental.UI.Button)_formPerio.Controls.Find("butCopyPrevious",true)[0];
					but.PerformClick();
					response=action.ToString();
					break;
				case VoiceCommandAction.SkipToToothOneFacial:
					_curCell=new Point(1,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwoFacial:
					_curCell=new Point(4,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThreeFacial:
					_curCell=new Point(7,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFourFacial:
					_curCell=new Point(10,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFiveFacial:
					_curCell=new Point(13,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSixFacial:
					_curCell=new Point(16,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSevenFacial:
					_curCell=new Point(19,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothEightFacial:
					_curCell=new Point(22,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothNineFacial:
					_curCell=new Point(25,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTenFacial:
					_curCell=new Point(28,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothElevenFacial:
					_curCell=new Point(31,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwelveFacial:
					_curCell=new Point(34,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirteenFacial:
					_curCell=new Point(37,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFourteenFacial:
					_curCell=new Point(40,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFifteenFacial:
					_curCell=new Point(43,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSixteenFacial:
					_curCell=new Point(46,6-Math.Min(6,_selectedExam+1));
					break;
			}
			SayResponse(response);
			SayResponse(ToothNumIfChanged(),200);
		}

		private string ToothNumIfChanged() {
			int newToothNum=GetPerioLocation().ToothNum;
			if(_curToothNum != newToothNum) {
				_curToothNum=newToothNum;
				return "Tooth "+newToothNum+" ";
			}
			return "";
		}

		private PerioLocation GetPerioLocation() {
			PerioLocation perioLoc=new PerioLocation();
			if(_curCell.Y>=13 &&_curCell.Y<=30) {
				perioLoc.Surface=PerioSurface.Labial;
			}
			else {
				perioLoc.Surface=PerioSurface.Facial;
			}
			if(_curCell.Y<=20) {
				perioLoc.ToothNum=(_curCell.X+2)/3;
			}
			else {
				perioLoc.ToothNum=33-(_curCell.X+2)/3;
			}



			return perioLoc;
		}

		private class PerioLocation {
			public int ToothNum;
			public int ProbingPosition;
			public PerioSurface Surface;
			public MeasurementType MeasureType;
		}

		private enum PerioSurface {
			Facial,
			Labial
		}

		private enum MeasurementType {
			Probing,
			MucoGingivalJunction,
			GingivalMargin,
			Furcation,
			Mobility
		}
	}
		
}
