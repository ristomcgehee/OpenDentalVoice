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
using OpenDental;
using OpenDentBusiness;
using System;
using System.Collections.Generic;
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
				return _gridP.SelectedExam;
			}
		}
		private ContrPerio _gridP {
			get {
				return ((ContrPerio)_formPerio.Controls.Find("gridP",true)[0]);
			}
		}
		private Point _curCell {
			get {
				return (Point)typeof(ContrPerio).GetField("CurCell",BindingFlags.NonPublic|BindingFlags.Instance)
					.GetValue(_gridP);
			}
			set {
				MethodInfo dynMethod= _gridP.GetType().GetMethod("SetNewCell",
					BindingFlags.NonPublic|BindingFlags.Instance);
				dynMethod.Invoke(_gridP,new object[] { value.X,value.Y });
			}
		}
		private PerioExam _perioExam {
			get	{
				return (PerioExam)typeof(FormPerio).GetField("PerioExamCur", BindingFlags.NonPublic | BindingFlags.Instance)
					.GetValue(_formPerio);
			}
		}
		private List<string> _listMissingTeeth {
			get {
				return (List<string>)typeof(FormPerio).GetField("_listMissingTeeth",BindingFlags.NonPublic | BindingFlags.Instance)
					.GetValue(_formPerio);
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
			_curLocation=GetPerioLocation();
			string response="";
			switch(action) {
				case VoiceCommandAction.CreatePerioChart:
					OpenDental.UI.Button but=(OpenDental.UI.Button)_formPerio.Controls.Find("butAdd",true)[0];
					but.PerformClick();
					response="Adding perio chart";
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
				case VoiceCommandAction.GoToToothOneFacial:
					_curCell=new Point(1,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwoFacial:
					_curCell=new Point(4,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThreeFacial:
					_curCell=new Point(7,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFourFacial:
					_curCell=new Point(10,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFiveFacial:
					_curCell=new Point(13,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSixFacial:
					_curCell=new Point(16,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSevenFacial:
					_curCell=new Point(19,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothEightFacial:
					_curCell=new Point(22,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothNineFacial:
					_curCell=new Point(25,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTenFacial:
					_curCell=new Point(28,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothElevenFacial:
					_curCell=new Point(31,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwelveFacial:
					_curCell=new Point(34,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirteenFacial:
					_curCell=new Point(37,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFourteenFacial:
					_curCell=new Point(40,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFifteenFacial:
					_curCell=new Point(43,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSixteenFacial:
					_curCell=new Point(46,6-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSeventeenFacial:
					_curCell=new Point(46,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothEighteenFacial:
					_curCell=new Point(43,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothNineteenFacial:
					_curCell=new Point(40,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyFacial:
					_curCell=new Point(37,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyOneFacial:
					_curCell=new Point(34,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyTwoFacial:
					_curCell=new Point(31,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyThreeFacial:
					_curCell=new Point(28,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyFourFacial:
					_curCell=new Point(25,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyFiveFacial:
					_curCell=new Point(22,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentySixFacial:
					_curCell=new Point(19,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentySevenFacial:
					_curCell=new Point(16,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyEightFacial:
					_curCell=new Point(13,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyNineFacial:
					_curCell=new Point(10,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyFacial:
					_curCell=new Point(7,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyOneFacial:
					_curCell=new Point(4,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyTwoFacial:
					_curCell=new Point(1,36+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothOneLingual:
					_curCell=new Point(3,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwoLingual:
					_curCell=new Point(6,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThreeLingual:
					_curCell=new Point(9,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFourLingual:
					_curCell=new Point(12,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFiveLingual:
					_curCell=new Point(15,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSixLingual:
					_curCell=new Point(18,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSevenLingual:
					_curCell=new Point(21,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothEightLingual:
					_curCell=new Point(24,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothNineLingual:
					_curCell=new Point(27,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTenLingual:
					_curCell=new Point(30,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothElevenLingual:
					_curCell=new Point(33,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwelveLingual:
					_curCell=new Point(36,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirteenLingual:
					_curCell=new Point(39,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFourteenLingual:
					_curCell=new Point(42,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothFifteenLingual:
					_curCell=new Point(43,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSixteenLingual:
					_curCell=new Point(46,14+Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothSeventeenLingual:
					_curCell=new Point(48,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothEighteenLingual:
					_curCell=new Point(45,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothNineteenLingual:
					_curCell=new Point(42,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyLingual:
					_curCell=new Point(39,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyOneLingual:
					_curCell=new Point(36,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyTwoLingual:
					_curCell=new Point(33,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyThreeLingual:
					_curCell=new Point(30,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyFourLingual:
					_curCell=new Point(27,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyFiveLingual:
					_curCell=new Point(24,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentySixLingual:
					_curCell=new Point(21,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentySevenLingual:
					_curCell=new Point(18,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyEightLingual:
					_curCell=new Point(15,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothTwentyNineLingual:
					_curCell=new Point(12,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyLingual:
					_curCell=new Point(9,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyOneLingual:
					_curCell=new Point(6,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.GoToToothThirtyTwoLingual:
					_curCell=new Point(3,27-Math.Min(6,_selectedExam+1));
					break;
				case VoiceCommandAction.Probing:
					GoToProbing();
					response=action.ToString();
					break;
				case VoiceCommandAction.MucoGingivalJunction:
					GoToMGJ();
					response="MGJ";
					break;
				case VoiceCommandAction.GingivalMargin:
					GoToGingivalMargin();
					response="Gingival Margin";
					break;
				case VoiceCommandAction.Furcation:
					GoToFurcation();
					response=action.ToString();
					break;
				case VoiceCommandAction.Mobility:
					GoToMobility();
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusOne:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but1",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusTwo:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but2",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusThree:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but3",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusFour:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but4",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusFive:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but5",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusSix:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but6",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusSeven:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but7",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusEight:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but8",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.PlusNine:
					_gridP.GingMargPlus=true;
					((OpenDental.UI.Button)_formPerio.Controls.Find("but9",true)[0]).PerformClick();
					_gridP.GingMargPlus=false;
					response=action.ToString();
					break;
				case VoiceCommandAction.SkipToothOne:
					SkipTooth(1);
					break;
				case VoiceCommandAction.SkipToothTwo:
					SkipTooth(2);
					break;
				case VoiceCommandAction.SkipToothThree:
					SkipTooth(3);
					break;
				case VoiceCommandAction.SkipToothFour:
					SkipTooth(4);
					break;
				case VoiceCommandAction.SkipToothFive:
					SkipTooth(5);
					break;
				case VoiceCommandAction.SkipToothSix:
					SkipTooth(6);
					break;
				case VoiceCommandAction.SkipToothSeven:
					SkipTooth(7);
					break;
				case VoiceCommandAction.SkipToothEight:
					SkipTooth(8);
					break;
				case VoiceCommandAction.SkipToothNine:
					SkipTooth(9);
					break;
				case VoiceCommandAction.SkipToothTen:
					SkipTooth(10);
					break;
				case VoiceCommandAction.SkipToothEleven:
					SkipTooth(11);
					break;
				case VoiceCommandAction.SkipToothTwelve:
					SkipTooth(12);
					break;
				case VoiceCommandAction.SkipToothThirteen:
					SkipTooth(13);
					break;
				case VoiceCommandAction.SkipToothFourteen:
					SkipTooth(14);
					break;
				case VoiceCommandAction.SkipToothFifteen:
					SkipTooth(15);
					break;
				case VoiceCommandAction.SkipToothSixteen:
					SkipTooth(16);
					break;
				case VoiceCommandAction.SkipToothSeventeen:
					SkipTooth(17);
					break;
				case VoiceCommandAction.SkipToothEighteen:
					SkipTooth(18);
					break;
				case VoiceCommandAction.SkipToothNineteen:
					SkipTooth(19);
					break;
				case VoiceCommandAction.SkipToothTwenty:
					SkipTooth(20);
					break;
				case VoiceCommandAction.SkipToothTwentyOne:
					SkipTooth(21);
					break;
				case VoiceCommandAction.SkipToothTwentyTwo:
					SkipTooth(22);
					break;
				case VoiceCommandAction.SkipToothTwentyThree:
					SkipTooth(23);
					break;
				case VoiceCommandAction.SkipToothTwentyFour:
					SkipTooth(24);
					break;
				case VoiceCommandAction.SkipToothTwentyFive:
					SkipTooth(25);
					break;
				case VoiceCommandAction.SkipToothTwentySix:
					SkipTooth(26);
					break;
				case VoiceCommandAction.SkipToothTwentySeven:
					SkipTooth(27);
					break;
				case VoiceCommandAction.SkipToothTwentyEight:
					SkipTooth(28);
					break;
				case VoiceCommandAction.SkipToothTwentyNine:
					SkipTooth(29);
					break;
				case VoiceCommandAction.SkipToothThirty:
					SkipTooth(30);
					break;
				case VoiceCommandAction.SkipToothThirtyOne:
					SkipTooth(31);
					break;
				case VoiceCommandAction.SkipToothThirtyTwo:
					SkipTooth(32);
					break;
				case VoiceCommandAction.SkipCurrentTooth:
					SkipTooth(_curLocation.ToothNum);
					break;
				default:
					break;
			}
			SayResponse(response);
			_prevLocation=_curLocation.Copy();
			_curLocation=GetPerioLocation();
			SetAutoAdvance();
			if(_prevLocation != null && _prevLocation.ToothNum != _curLocation.ToothNum) {
				SayResponse("Tooth "+_curLocation.ToothNum);
			}
		}

		private void SkipTooth(int toothNum) {
			IsListening=false;
			if(!VoiceMsgBox.Show("Mark tooth "+toothNum+" as skipped?",MsgBoxButtons.YesNo)) {
				IsListening=true;
				return;
			}
			IsListening=true;
			Point curSpot=new Point(_curCell.X,_curCell.Y);
			bool radioRightChecked=((RadioButton)_formPerio.Controls.Find("radioRight",true)[0]).Checked;
			if(Assembly.GetAssembly(typeof(FormPerio)).GetName().Version >= new Version(16,4)) {
				//_gridP.SaveCurExam(_perioExam);
				MethodInfo method=_gridP.GetType().GetMethod(nameof(ContrPerio.SaveCurExam),BindingFlags.Public|BindingFlags.Instance);
				method.Invoke(_gridP,new object[] { _perioExam });
			}
			else {//16.3
				//_gridP.SaveCurExam(_perioExam.PerioExamNum);
				MethodInfo method=_gridP.GetType().GetMethod(nameof(ContrPerio.SaveCurExam),BindingFlags.Public|BindingFlags.Instance);
				method.Invoke(_gridP,new object[] { _perioExam.PerioExamNum });
			}
			int selectedExam=_selectedExam;
			List<int> listSkippedTeeth=new List<int>();//int 1-32
			if(PerioExams.ListExams.Count > 0) {
				//set skipped teeth based on the last exam in the list: 
				listSkippedTeeth=PerioMeasures.GetSkipped(PerioExams.ListExams[PerioExams.ListExams.Count-1].PerioExamNum);
			}
			if(!listSkippedTeeth.Contains(toothNum)) {
				listSkippedTeeth.Add(toothNum);
			}
			PerioMeasures.SetSkipped(_perioExam.PerioExamNum,listSkippedTeeth);
			MethodInfo dynMethod=_formPerio.GetType().GetMethod("RefreshListExams",
				BindingFlags.NonPublic|BindingFlags.Instance);
			dynMethod.Invoke(_formPerio,new object[] { });
			((ListBox)_formPerio.Controls.Find("listExams",true)[0]).SelectedIndex=selectedExam;
			dynMethod=_formPerio.GetType().GetMethod("FillGrid",
				BindingFlags.NonPublic|BindingFlags.Instance);
			dynMethod.Invoke(_formPerio,new object[] { });
			_curCell=curSpot;
			if(radioRightChecked) {
				ClickAdvanceRight();
			}
			//else it will be left by default
			if(_curLocation.ToothNum==toothNum) {//Skipping the current tooth
				AdvanceToNextTooth();
			}
		}

		private void AdvanceToNextTooth() {
			
			int origToothNum=_curLocation.ToothNum;
			bool radioRightChecked=((RadioButton)_formPerio.Controls.Find("radioRight",true)[0]).Checked;
			SendKeys.Send(radioRightChecked ? "{LEFT}" : "{RIGHT}");
			if(origToothNum != GetPerioLocation().ToothNum) {
				return;
			}
			SendKeys.Send(radioRightChecked ? "{LEFT}" : "{RIGHT}");
			if (origToothNum != GetPerioLocation().ToothNum) {
				return;
			}
			SendKeys.Send(radioRightChecked ? "{LEFT}" : "{RIGHT}");
			if (origToothNum != GetPerioLocation().ToothNum) {
				return;
			}
			//Say new tooth
		}

		private void GoToMobility() {
			int yVal;
			int xVal;
			if(_curLocation.ToothNum <= 16) {
				xVal=(_curLocation.ToothNum-1)*3+2;//Middle cell
				yVal=10;
			}
			else {//ToothNum >= 17
				xVal=xVal=47-(_curLocation.ToothNum-17)*3;
				yVal=32;
			}
			_curCell=new Point(xVal,yVal);
		}

		private void GoToGingivalMargin() {
			int yVal;
			if(_curLocation.Surface==PerioSurface.Facial) {
				if(_curLocation.ToothNum<=16) {
					yVal=7;
				}
				else {//ToothNum >= 17
					yVal=35;
				}
			}
			else {//Lingual
				if(_curLocation.ToothNum<=16) {
					yVal=14;
				}
				else {//ToothNum >= 17
					yVal=28;
				}
			}
			_curCell=new Point(FirstEmptyPositionX(yVal),yVal);
		}

		private void GoToFurcation() {
			int yVal;
			if(_curLocation.Surface==PerioSurface.Facial) {
				if(_curLocation.ToothNum<=16) {
					yVal=9;
				}
				else {//ToothNum >= 17
					yVal=33;
				}
			}
			else {//Lingual
				if(_curLocation.ToothNum<=16) {
					yVal=12;
				}
				else {//ToothNum >= 17
					yVal=30;
				}
			}
			_curCell=new Point(FirstEmptyPositionX(yVal),yVal);
		}

		private void GoToMGJ() {
			int yVal;
			if(_curLocation.Surface==PerioSurface.Facial) {
				if(_curLocation.ToothNum<=16) {
					yVal=6;
				}
				else {//ToothNum >= 17
					yVal=36;
				}
			}
			else {//Lingual
				yVal=27;
			}
			_curCell=new Point(FirstEmptyPositionX(yVal),yVal);
		}

		private void GoToProbing() {
			int yVal;
			if(_curLocation.Surface==PerioSurface.Facial) {
				if(_curLocation.ToothNum<=16) {
					yVal=6-Math.Min(6,_selectedExam+1);
				}
				else {//ToothNum >= 17
					yVal=36+Math.Min(6,_selectedExam+1);
				}
			}
			else {//Lingual
				if(_curLocation.ToothNum<=16) {
					yVal=14+Math.Min(6,_selectedExam+1);
				}
				else {//ToothNum >= 17
					yVal=27-Math.Min(6,_selectedExam+1);
				}
			}
			_curCell=new Point(FirstEmptyPositionX(yVal),yVal);
		}

		private int FirstEmptyPositionX(int yVal) {
			int xVal;
			if(_curLocation.Surface==PerioSurface.Facial) {
				if(_curLocation.ToothNum<=16) {
					xVal=(_curLocation.ToothNum-1)*3+1;
				}
				else {//ToothNum >= 17
					xVal=46-(_curLocation.ToothNum-17)*3;
				}
				if(string.IsNullOrEmpty(GetTextInCell(xVal,yVal))) {
					return xVal;
				}
				xVal++;
				if(string.IsNullOrEmpty(GetTextInCell(xVal,yVal))) {
					return xVal;
				}
				return ++xVal;
			}
			else {//Lingual
				if(_curLocation.ToothNum<=16) {
					xVal=(_curLocation.ToothNum-1)*3+3;
				}
				else {//ToothNum >= 17
					xVal=48-(_curLocation.ToothNum-17)*3;
				}
				if(string.IsNullOrEmpty(GetTextInCell(xVal,yVal))) {
					return xVal;
				}
				xVal--;
				if(string.IsNullOrEmpty(GetTextInCell(xVal,yVal))) {
					return xVal;
				}
				return --xVal;
			}
		}

		private void SetAutoAdvance() {
			if(_prevLocation==null) {
				return;
			}
			if(_prevLocation.Surface==PerioSurface.Facial && _curLocation.Surface==PerioSurface.Lingual) 
			{
				ClickAdvanceRight();
			}
			if(_prevLocation.Surface==PerioSurface.Lingual && _curLocation.Surface==PerioSurface.Facial) 
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
				perioLoc.Surface=PerioSurface.Lingual;
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
			if(perioLoc.Surface==PerioSurface.Facial) {
				perioLoc.ProbingPosition=(_curCell.X-1)%3+1;
			}
			else {
				perioLoc.ProbingPosition=3-(_curCell.X-1)%3;
			}
			//Still need to calculate the MeasureType			
			perioLoc.Text=GetTextInCell(_curCell.X,_curCell.Y);
			return perioLoc;
		}

		private string GetTextInCell(int x,int y) {
			try {
				PerioCell[,] perioData = (PerioCell[,])typeof(ContrPerio).GetField("DataArray",BindingFlags.NonPublic|BindingFlags.Instance)
					.GetValue(_gridP);
				return perioData[x,y].Text;
			}
			catch {
				return "";
			}
		}

		private class PerioLocation {
			public int ToothNum;
			public int ProbingPosition;
			public PerioSurface Surface;
			//public MeasurementType MeasureType;
			public string Text;

			public PerioLocation Copy() {
				return (PerioLocation)MemberwiseClone();
			}
		}

		private enum PerioSurface {
			Facial,
			Lingual
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
