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
		private PerioLocation _curLocation;
		private PerioLocation _prevLocation;
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
			_curLocation=GetPerioLocation();
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
				case VoiceCommandAction.SkipToToothSeventeenFacial:
					_curCell=new Point(46,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothEighteenFacial:
					_curCell=new Point(43,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothNineteenFacial:
					_curCell=new Point(40,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyFacial:
					_curCell=new Point(37,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyOneFacial:
					_curCell=new Point(34,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyTwoFacial:
					_curCell=new Point(31,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyThreeFacial:
					_curCell=new Point(28,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyFourFacial:
					_curCell=new Point(25,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyFiveFacial:
					_curCell=new Point(22,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentySixFacial:
					_curCell=new Point(19,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentySevenFacial:
					_curCell=new Point(16,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyEightFacial:
					_curCell=new Point(13,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyNineFacial:
					_curCell=new Point(10,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyFacial:
					_curCell=new Point(7,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyOneFacial:
					_curCell=new Point(4,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyTwoFacial:
					_curCell=new Point(1,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothOneLabial:
					_curCell=new Point(3,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwoLabial:
					_curCell=new Point(6,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThreeLabial:
					_curCell=new Point(9,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFourLabial:
					_curCell=new Point(12,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFiveLabial:
					_curCell=new Point(15,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSixLabial:
					_curCell=new Point(18,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSevenLabial:
					_curCell=new Point(21,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothEightLabial:
					_curCell=new Point(24,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothNineLabial:
					_curCell=new Point(27,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTenLabial:
					_curCell=new Point(30,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothElevenLabial:
					_curCell=new Point(33,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwelveLabial:
					_curCell=new Point(36,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirteenLabial:
					_curCell=new Point(39,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFourteenLabial:
					_curCell=new Point(42,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothFifteenLabial:
					_curCell=new Point(43,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSixteenLabial:
					_curCell=new Point(46,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothSeventeenLabial:
					_curCell=new Point(48,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothEighteenLabial:
					_curCell=new Point(45,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothNineteenLabial:
					_curCell=new Point(42,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyLabial:
					_curCell=new Point(39,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyOneLabial:
					_curCell=new Point(36,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyTwoLabial:
					_curCell=new Point(33,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyThreeLabial:
					_curCell=new Point(30,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyFourLabial:
					_curCell=new Point(27,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyFiveLabial:
					_curCell=new Point(24,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentySixLabial:
					_curCell=new Point(21,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentySevenLabial:
					_curCell=new Point(18,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyEightLabial:
					_curCell=new Point(15,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothTwentyNineLabial:
					_curCell=new Point(12,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyLabial:
					_curCell=new Point(9,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyOneLabial:
					_curCell=new Point(6,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.SkipToToothThirtyTwoLabial:
					_curCell=new Point(3,27-Math.Min(6,_selectedExam+1));
					break;
			}
			SayResponse(response);
			_prevLocation=_curLocation.Copy();
			_curLocation=GetPerioLocation();
			SetAutoAdvance();
			if(_prevLocation!=null && _prevLocation.ToothNum!=_curLocation.ToothNum) {
				SayResponse("Tooth "+_curLocation.ToothNum,100);
			}
		}
		
		private void SetAutoAdvance() {
			if(_prevLocation==null) {
				return;
			}
			if(_prevLocation.Surface==PerioSurface.Facial && _curLocation.Surface==PerioSurface.Labial) 
			{
				ClickAdvanceRight();
			}
			if(_prevLocation.Surface==PerioSurface.Labial && _curLocation.Surface==PerioSurface.Facial) 
			{
				ClickAdvanceLeft();
			}
		}

		private void ClickAdvanceLeft() {
			MethodInfo dynMethod=_formPerio.GetType().GetMethod("radioLeft_Click",
				BindingFlags.NonPublic|BindingFlags.Instance);
			dynMethod.Invoke(_formPerio,new object[] { _formPerio,new EventArgs() });
			RadioButton radioLeft=(RadioButton)_formPerio.Controls.Find("radioLeft",true)[0];
			radioLeft.Checked=true;
			RadioButton radioRight=(RadioButton)_formPerio.Controls.Find("radioRight",true)[0];
			radioRight.Checked=false;
		}

		private void ClickAdvanceRight() {
			MethodInfo dynMethod=_formPerio.GetType().GetMethod("radioRight_Click",
				BindingFlags.NonPublic|BindingFlags.Instance);
			dynMethod.Invoke(_formPerio,new object[] { _formPerio,new EventArgs() });
			RadioButton radioLeft=(RadioButton)_formPerio.Controls.Find("radioLeft",true)[0];
			radioLeft.Checked=false;
			RadioButton radioRight=(RadioButton)_formPerio.Controls.Find("radioRight",true)[0];
			radioRight.Checked=true;
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

			public PerioLocation Copy() {
				return (PerioLocation)MemberwiseClone();
			}
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
