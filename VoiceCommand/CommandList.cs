using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceCommand {
	public class CommandList {
		public static List<VoiceCommand> Commands {
			get {
				return new List<VoiceCommand> {
					#region Global
					new VoiceCommand {
						Commands=new List<string> {
							"hey open dental",
							"okay open dental"
						},
						Action=VoiceCommandAction.StartListening,
						Area=VoiceCommandArea.Global
					},
					new VoiceCommand {
						Commands=new List<string> {
							"good bye open dental",
						},
						Action=VoiceCommandAction.StopListening,
						Area=VoiceCommandArea.Global
					},
					new VoiceCommand {
						Commands=new List<string> {
							"give feedback",
							"start giving feedback",
							"turn feedback on"
						},
						Action=VoiceCommandAction.GiveFeedback,
						Area=VoiceCommandArea.Global
					},
					new VoiceCommand {
						Commands=new List<string> {
							"stop giving feedback",
							"turn feedback off"
						},
						Action=VoiceCommandAction.StopGivingFeedback,
						Area=VoiceCommandArea.Global
					},
					new VoiceCommand {
						Commands=new List<string> {	},
						Action=VoiceCommandAction.DidntGetThat,
						Area=VoiceCommandArea.Global|VoiceCommandArea.VoiceMsgBox
					},
					#endregion Global
					#region FormOpenDental
					new VoiceCommand {
						Commands=new List<string> {
							"select patient",
							"choose patient"
						},
						Action=VoiceCommandAction.SelectPatient,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to appointment module"
						},
						Action=VoiceCommandAction.GoToAppointmentModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to family module"
						},
						Action=VoiceCommandAction.GoToFamilyModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to account",
							"go to account module"
						},
						Action=VoiceCommandAction.GoToAccountModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to treatment plan",
							"go to treatment plan module"
						},
						Action=VoiceCommandAction.GoToTreatmentPlanModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to chart",
							"go to chart module"
						},
						Action=VoiceCommandAction.GoToChartModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to images",
							"go to image module"
						},
						Action=VoiceCommandAction.GoToImageModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to manage module"
						},
						Action=VoiceCommandAction.GoToManageModule,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"create comm log",
							"create new comm log"
						},
						Action=VoiceCommandAction.CreateCommlog,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"send email",
							"create new email"
						},
						Action=VoiceCommandAction.SendEmail,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"create new form",
							"create new patient form",
							"create patient form"
						},
						Action=VoiceCommandAction.CreatePatientForm,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"create payment",
							"create new payment",
							"create new patient payment",
							"new payment",
							"new patient payment"
						},
						Action=VoiceCommandAction.CreatePatientPayment,
						Area=VoiceCommandArea.FormOpenDental
					},
					new VoiceCommand {
						Commands=new List<string> {
							"open perio chart",
						},
						Action=VoiceCommandAction.OpenPerioChart,
						Area=VoiceCommandArea.FormOpenDental
					},
					#endregion FormOpenDental
					#region PerioChart
					new VoiceCommand {
						Commands=new List<string> {
							"add perio chart",
							"new perio chart"
						},
						Action=VoiceCommandAction.CreatePerioChart,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"zero"
						},
						Action=VoiceCommandAction.Zero,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"one"
						},
						Action=VoiceCommandAction.One,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"two"
						},
						Action=VoiceCommandAction.Two,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"three"
						},
						Action=VoiceCommandAction.Three,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"four"
						},
						Action=VoiceCommandAction.Four,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"five"
						},
						Action=VoiceCommandAction.Five,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"six"
						},
						Action=VoiceCommandAction.Six,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"seven"
						},
						Action=VoiceCommandAction.Seven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"eight"
						},
						Action=VoiceCommandAction.Eight,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"nine"
						},
						Action=VoiceCommandAction.Nine,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"ten"
						},
						Action=VoiceCommandAction.Ten,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"eleven"
						},
						Action=VoiceCommandAction.Eleven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"twelve"
						},
						Action=VoiceCommandAction.Twelve,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"thirteen"
						},
						Action=VoiceCommandAction.Thirteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"fourteen"
						},
						Action=VoiceCommandAction.Fourteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"fifteen"
						},
						Action=VoiceCommandAction.Fifteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"sixteen"
						},
						Action=VoiceCommandAction.Sixteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"seventeen"
						},
						Action=VoiceCommandAction.Seventeen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"eightteen"
						},
						Action=VoiceCommandAction.Eightteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"nineteen"
						},
						Action=VoiceCommandAction.Nineteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"triplet",
							"triplets",
							"check triplets",
							"uncheck triplets",
						},
						Action=VoiceCommandAction.Triplet,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"bleeding",
							"mark bleeding"
						},
						Action=VoiceCommandAction.Bleeding,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"calculus",
							"mark calculus"
						},
						Action=VoiceCommandAction.Calculus,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plaque"
						},
						Action=VoiceCommandAction.Plaque,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"suppuration"
						},
						Action=VoiceCommandAction.Suppuration,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							//"back", //This got confused with 'five' too often.
							"backspace"
						},
						Action=VoiceCommandAction.Backspace,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"left"
						},
						Action=VoiceCommandAction.Left,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"right"
						},
						Action=VoiceCommandAction.Right,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"delete"
						},
						Action=VoiceCommandAction.Delete,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"copy previous",
							"copy previous exam"
						},
						Action=VoiceCommandAction.CopyPrevious,
						Area=VoiceCommandArea.PerioChart
					},

					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth one facial",
							"go to one facial"
						},
						Action=VoiceCommandAction.GoToToothOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth two facial",
							"go to two facial"
						},
						Action=VoiceCommandAction.GoToToothTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth three facial",
							"go to three facial"
						},
						Action=VoiceCommandAction.GoToToothThreeFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth four facial",
							"go to four facial"
						},
						Action=VoiceCommandAction.GoToToothFourFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth five facial",
							"go to five facial"
						},
						Action=VoiceCommandAction.GoToToothFiveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth six facial",
							"go to six facial"
						},
						Action=VoiceCommandAction.GoToToothSixFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth seven facial",
							"go to seven facial"
						},
						Action=VoiceCommandAction.GoToToothSevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eight facial",
							"go to eight facial"
						},
						Action=VoiceCommandAction.GoToToothEightFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth nine facial",
							"go to nine facial"
						},
						Action=VoiceCommandAction.GoToToothNineFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth ten facial",
							"go to ten facial"
						},
						Action=VoiceCommandAction.GoToToothTenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eleven facial",
							"go to eleven facial"
						},
						Action=VoiceCommandAction.GoToToothElevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twelve facial",
							"go to twelve facial"
						},
						Action=VoiceCommandAction.GoToToothTwelveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirteen facial",
							"go to thirteen facial"
						},
						Action=VoiceCommandAction.GoToToothThirteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth fourteen facial",
							"go to fourteen facial"
						},
						Action=VoiceCommandAction.GoToToothFourteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth fifteen facial",
							"go to fifteen facial"
						},
						Action=VoiceCommandAction.GoToToothFifteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth sixteen facial",
							"go to sixteen facial"
						},
						Action=VoiceCommandAction.GoToToothSixteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth seventeen facial",
							"go to seventeen facial"
						},
						Action=VoiceCommandAction.GoToToothSeventeenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eighteen facial",
							"go to eighteen facial"
						},
						Action=VoiceCommandAction.GoToToothEighteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth nineteen facial",
							"go to nineteen facial"
						},
						Action=VoiceCommandAction.GoToToothNineteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty facial",
							"go to twenty facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty one facial",
							"go to twenty one facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty two facial",
							"go to twenty two facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty three facial",
							"go to twenty three facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyThreeFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty four facial",
							"go to twenty four facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyFourFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty five facial",
							"go to twenty five facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyFiveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty six facial",
							"go to twenty six facial"
						},
						Action=VoiceCommandAction.GoToToothTwentySixFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty seven facial",
							"go to twenty seven facial"
						},
						Action=VoiceCommandAction.GoToToothTwentySevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty eight facial",
							"go to twenty eight facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyEightFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty nine facial",
							"go to twenty nine facial"
						},
						Action=VoiceCommandAction.GoToToothTwentyNineFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty facial",
							"go to thirty facial"
						},
						Action=VoiceCommandAction.GoToToothThirtyFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty one facial",
							"go to thirty one facial"
						},
						Action=VoiceCommandAction.GoToToothThirtyOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty two facial",
							"go to thirty two facial"
						},
						Action=VoiceCommandAction.GoToToothThirtyTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth one lingual",
							"go to one lingual"
						},
						Action=VoiceCommandAction.GoToToothOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth two lingual",
							"go to two lingual"
						},
						Action=VoiceCommandAction.GoToToothTwoLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth three lingual",
							"go to three lingual"
						},
						Action=VoiceCommandAction.GoToToothThreeLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth four lingual",
							"go to four lingual"
						},
						Action=VoiceCommandAction.GoToToothFourLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth five lingual",
							"go to five lingual"
						},
						Action=VoiceCommandAction.GoToToothFiveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth six lingual",
							"go to six lingual"
						},
						Action=VoiceCommandAction.GoToToothSixLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth seven lingual",
							"go to seven lingual"
						},
						Action=VoiceCommandAction.GoToToothSevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eight lingual",
							"go to eight lingual"
						},
						Action=VoiceCommandAction.GoToToothEightLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth nine lingual",
							"go to nine lingual"
						},
						Action=VoiceCommandAction.GoToToothNineLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth ten lingual",
							"go to ten lingual"
						},
						Action=VoiceCommandAction.GoToToothTenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eleven lingual",
							"go to eleven lingual"
						},
						Action=VoiceCommandAction.GoToToothElevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twelve lingual",
							"go to twelve lingual"
						},
						Action=VoiceCommandAction.GoToToothTwelveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirteen lingual",
							"go to thirteen lingual"
						},
						Action=VoiceCommandAction.GoToToothThirteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth fourteen lingual",
							"go to fourteen lingual"
						},
						Action=VoiceCommandAction.GoToToothFourteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth fifteen lingual",
							"go to fifteen lingual"
						},
						Action=VoiceCommandAction.GoToToothFifteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth sixteen lingual",
							"go to sixteen lingual"
						},
						Action=VoiceCommandAction.GoToToothSixteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth seventeen lingual",
							"go to seventeen lingual"
						},
						Action=VoiceCommandAction.GoToToothSeventeenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth eighteen lingual",
							"go to eighteen lingual"
						},
						Action=VoiceCommandAction.GoToToothEighteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth nineteen lingual",
							"go to nineteen lingual"
						},
						Action=VoiceCommandAction.GoToToothNineteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty lingual",
							"go to twenty lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty one lingual",
							"go to twenty one lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty two lingual",
							"go to twenty two lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyTwoLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty three lingual",
							"go to twenty three lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyThreeLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty four lingual",
							"go to twenty four lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyFourLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty five lingual",
							"go to twenty five lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyFiveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty six lingual",
							"go to twenty six lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentySixLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty seven lingual",
							"go to twenty seven lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentySevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty eight lingual",
							"go to twenty eight lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyEightLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth twenty nine lingual",
							"go to twenty nine lingual"
						},
						Action=VoiceCommandAction.GoToToothTwentyNineLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty lingual",
							"go to thirty lingual"
						},
						Action=VoiceCommandAction.GoToToothThirtyLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty one lingual",
							"go to thirty one lingual"
						},
						Action=VoiceCommandAction.GoToToothThirtyOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"go to tooth thirty two lingual",
							"go to thirty two lingual"
						},
						Action=VoiceCommandAction.GoToToothThirtyTwoLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"probing"
						},
						Action=VoiceCommandAction.Probing,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"Muco Gingival Junction",
							"MGJ"
						},
						Action=VoiceCommandAction.MucoGingivalJunction,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"Gingival Margin"
						},
						Action=VoiceCommandAction.GingivalMargin,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"Furcation"
						},
						Action=VoiceCommandAction.Furcation,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"mobility"
						},
						Action=VoiceCommandAction.Mobility,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus one"
						},
						Action=VoiceCommandAction.PlusOne,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus two"
						},
						Action=VoiceCommandAction.PlusTwo,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus three"
						},
						Action=VoiceCommandAction.PlusThree,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus four"
						},
						Action=VoiceCommandAction.PlusFour,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus five"
						},
						Action=VoiceCommandAction.PlusFive,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus six"
						},
						Action=VoiceCommandAction.PlusSix,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus seven"
						},
						Action=VoiceCommandAction.PlusSeven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus eight"
						},
						Action=VoiceCommandAction.PlusEight,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"plus nine"
						},
						Action=VoiceCommandAction.PlusNine,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth one"
						},
						Action=VoiceCommandAction.SkipToothOne,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth two"
						},
						Action=VoiceCommandAction.SkipToothTwo,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth three"
						},
						Action=VoiceCommandAction.SkipToothThree,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth four"
						},
						Action=VoiceCommandAction.SkipToothFour,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth five"
						},
						Action=VoiceCommandAction.SkipToothFive,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth six"
						},
						Action=VoiceCommandAction.SkipToothSix,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth seven"
						},
						Action=VoiceCommandAction.SkipToothSeven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth eight"
						},
						Action=VoiceCommandAction.SkipToothEight,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth nine"
						},
						Action=VoiceCommandAction.SkipToothNine,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth ten"
						},
						Action=VoiceCommandAction.SkipToothTen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth eleven"
						},
						Action=VoiceCommandAction.SkipToothEleven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twelve"
						},
						Action=VoiceCommandAction.SkipToothTwelve,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth thirteen"
						},
						Action=VoiceCommandAction.SkipToothThirteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth fouteen"
						},
						Action=VoiceCommandAction.SkipToothFourteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth fifteen"
						},
						Action=VoiceCommandAction.SkipToothFifteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth sixteen"
						},
						Action=VoiceCommandAction.SkipToothSixteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth seventeen"
						},
						Action=VoiceCommandAction.SkipToothSeventeen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth eighteen"
						},
						Action=VoiceCommandAction.SkipToothEighteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth nineteen"
						},
						Action=VoiceCommandAction.SkipToothNineteen,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty"
						},
						Action=VoiceCommandAction.SkipToothTwenty,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty one"
						},
						Action=VoiceCommandAction.SkipToothTwentyOne,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty two"
						},
						Action=VoiceCommandAction.SkipToothTwentyTwo,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty three"
						},
						Action=VoiceCommandAction.SkipToothTwentyThree,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty four"
						},
						Action=VoiceCommandAction.SkipToothTwentyFour,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty five"
						},
						Action=VoiceCommandAction.SkipToothTwentyFive,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty six"
						},
						Action=VoiceCommandAction.SkipToothTwentySix,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty seven"
						},
						Action=VoiceCommandAction.SkipToothTwentySeven,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty eight"
						},
						Action=VoiceCommandAction.SkipToothTwentyEight,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth twenty nine"
						},
						Action=VoiceCommandAction.SkipToothTwentyNine,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth thirty"
						},
						Action=VoiceCommandAction.SkipToothThirty,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth thirty one"
						},
						Action=VoiceCommandAction.SkipToothThirtyOne,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip tooth thirty two"
						},
						Action=VoiceCommandAction.SkipToothThirtyTwo,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip this tooth",
							"skip current tooth"
						},
						Action=VoiceCommandAction.SkipCurrentTooth,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"yes",
						},
						Action=VoiceCommandAction.Yes,
						Area=VoiceCommandArea.VoiceMsgBox
					},
					new VoiceCommand {
						Commands=new List<string> {
							"no",
						},
						Action=VoiceCommandAction.No,
						Area=VoiceCommandArea.VoiceMsgBox
					},
					new VoiceCommand {
						Commands=new List<string> {
							"okay",
						},
						Action=VoiceCommandAction.Ok,
						Area=VoiceCommandArea.VoiceMsgBox
					},
					new VoiceCommand {
						Commands=new List<string> {
							"cancel",
						},
						Action=VoiceCommandAction.Cancel,
						Area=VoiceCommandArea.VoiceMsgBox
					},


#endregion PerioChart
				};
			}
		}
	}
}
