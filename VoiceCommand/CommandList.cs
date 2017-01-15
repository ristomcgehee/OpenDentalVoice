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
						Area=VoiceCommandArea.Global
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
							"skip to tooth one facial",
							"skip to one facial"
						},
						Action=VoiceCommandAction.SkipToToothOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth two facial",
							"skip to two facial"
						},
						Action=VoiceCommandAction.SkipToToothTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth three facial",
							"skip to three facial"
						},
						Action=VoiceCommandAction.SkipToToothThreeFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth four facial",
							"skip to four facial"
						},
						Action=VoiceCommandAction.SkipToToothFourFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth five facial",
							"skip to five facial"
						},
						Action=VoiceCommandAction.SkipToToothFiveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth six facial",
							"skip to six facial"
						},
						Action=VoiceCommandAction.SkipToToothSixFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seven facial",
							"skip to seven facial"
						},
						Action=VoiceCommandAction.SkipToToothSevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eight facial",
							"skip to eight facial"
						},
						Action=VoiceCommandAction.SkipToToothEightFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nine facial",
							"skip to nine facial"
						},
						Action=VoiceCommandAction.SkipToToothNineFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth ten facial",
							"skip to ten facial"
						},
						Action=VoiceCommandAction.SkipToToothTenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eleven facial",
							"skip to eleven facial"
						},
						Action=VoiceCommandAction.SkipToToothElevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twelve facial",
							"skip to twelve facial"
						},
						Action=VoiceCommandAction.SkipToToothTwelveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirteen facial",
							"skip to thirteen facial"
						},
						Action=VoiceCommandAction.SkipToToothThirteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fourteen facial",
							"skip to fourteen facial"
						},
						Action=VoiceCommandAction.SkipToToothFourteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fifteen facial",
							"skip to fifteen facial"
						},
						Action=VoiceCommandAction.SkipToToothFifteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth sixteen facial",
							"skip to sixteen facial"
						},
						Action=VoiceCommandAction.SkipToToothSixteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seventeen facial",
							"skip to seventeen facial"
						},
						Action=VoiceCommandAction.SkipToToothSeventeenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eighteen facial",
							"skip to eighteen facial"
						},
						Action=VoiceCommandAction.SkipToToothEighteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nineteen facial",
							"skip to nineteen facial"
						},
						Action=VoiceCommandAction.SkipToToothNineteenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty facial",
							"skip to twenty facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty one facial",
							"skip to twenty one facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty two facial",
							"skip to twenty two facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty three facial",
							"skip to twenty three facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyThreeFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty four facial",
							"skip to twenty four facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFourFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty five facial",
							"skip to twenty five facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFiveFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty six facial",
							"skip to twenty six facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentySixFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty seven facial",
							"skip to twenty seven facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentySevenFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty eight facial",
							"skip to twenty eight facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyEightFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty nine facial",
							"skip to twenty nine facial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyNineFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty facial",
							"skip to thirty facial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty one facial",
							"skip to thirty one facial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyOneFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty two facial",
							"skip to thirty two facial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyTwoFacial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth one lingual",
							"skip to one lingual"
						},
						Action=VoiceCommandAction.SkipToToothOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth two lingual",
							"skip to two lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwoLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth three lingual",
							"skip to three lingual"
						},
						Action=VoiceCommandAction.SkipToToothThreeLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth four lingual",
							"skip to four lingual"
						},
						Action=VoiceCommandAction.SkipToToothFourLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth five lingual",
							"skip to five lingual"
						},
						Action=VoiceCommandAction.SkipToToothFiveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth six lingual",
							"skip to six lingual"
						},
						Action=VoiceCommandAction.SkipToToothSixLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seven lingual",
							"skip to seven lingual"
						},
						Action=VoiceCommandAction.SkipToToothSevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eight lingual",
							"skip to eight lingual"
						},
						Action=VoiceCommandAction.SkipToToothEightLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nine lingual",
							"skip to nine lingual"
						},
						Action=VoiceCommandAction.SkipToToothNineLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth ten lingual",
							"skip to ten lingual"
						},
						Action=VoiceCommandAction.SkipToToothTenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eleven lingual",
							"skip to eleven lingual"
						},
						Action=VoiceCommandAction.SkipToToothElevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twelve lingual",
							"skip to twelve lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwelveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirteen lingual",
							"skip to thirteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothThirteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fourteen lingual",
							"skip to fourteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothFourteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fifteen lingual",
							"skip to fifteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothFifteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth sixteen lingual",
							"skip to sixteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothSixteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seventeen lingual",
							"skip to seventeen lingual"
						},
						Action=VoiceCommandAction.SkipToToothSeventeenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eighteen lingual",
							"skip to eighteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothEighteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nineteen lingual",
							"skip to nineteen lingual"
						},
						Action=VoiceCommandAction.SkipToToothNineteenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty lingual",
							"skip to twenty lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty one lingual",
							"skip to twenty one lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty two lingual",
							"skip to twenty two lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyTwoLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty three lingual",
							"skip to twenty three lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyThreeLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty four lingual",
							"skip to twenty four lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFourLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty five lingual",
							"skip to twenty five lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFiveLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty six lingual",
							"skip to twenty six lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentySixLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty seven lingual",
							"skip to twenty seven lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentySevenLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty eight lingual",
							"skip to twenty eight lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyEightLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty nine lingual",
							"skip to twenty nine lingual"
						},
						Action=VoiceCommandAction.SkipToToothTwentyNineLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty lingual",
							"skip to thirty lingual"
						},
						Action=VoiceCommandAction.SkipToToothThirtyLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty one lingual",
							"skip to thirty one lingual"
						},
						Action=VoiceCommandAction.SkipToToothThirtyOneLingual,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty two lingual",
							"skip to thirty two lingual"
						},
						Action=VoiceCommandAction.SkipToToothThirtyTwoLingual,
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


#endregion PerioChart
				};
			}
		}
	}
}
