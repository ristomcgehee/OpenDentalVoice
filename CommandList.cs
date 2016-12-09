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
						Action=VoiceCommandAction.GoToAppointmentModule
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
						Action=VoiceCommandAction.SkipToTootSeventeenFacial,
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
							"skip to tooth one labial",
							"skip to one labial"
						},
						Action=VoiceCommandAction.SkipToToothOneLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth two labial",
							"skip to two labial"
						},
						Action=VoiceCommandAction.SkipToToothTwoLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth three labial",
							"skip to three labial"
						},
						Action=VoiceCommandAction.SkipToToothThreeLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth four labial",
							"skip to four labial"
						},
						Action=VoiceCommandAction.SkipToToothFourLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth five labial",
							"skip to five labial"
						},
						Action=VoiceCommandAction.SkipToToothFiveLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth six labial",
							"skip to six labial"
						},
						Action=VoiceCommandAction.SkipToToothSixLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seven labial",
							"skip to seven labial"
						},
						Action=VoiceCommandAction.SkipToToothSevenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eight labial",
							"skip to eight labial"
						},
						Action=VoiceCommandAction.SkipToToothEightLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nine labial",
							"skip to nine labial"
						},
						Action=VoiceCommandAction.SkipToToothNineLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth ten labial",
							"skip to ten labial"
						},
						Action=VoiceCommandAction.SkipToToothTenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eleven labial",
							"skip to eleven labial"
						},
						Action=VoiceCommandAction.SkipToToothElevenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twelve labial",
							"skip to twelve labial"
						},
						Action=VoiceCommandAction.SkipToToothTwelveLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirteen labial",
							"skip to thirteen labial"
						},
						Action=VoiceCommandAction.SkipToToothThirteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fourteen labial",
							"skip to fourteen labial"
						},
						Action=VoiceCommandAction.SkipToToothFourteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth fifteen labial",
							"skip to fifteen labial"
						},
						Action=VoiceCommandAction.SkipToToothFifteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth sixteen labial",
							"skip to sixteen labial"
						},
						Action=VoiceCommandAction.SkipToToothSixteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth seventeen labial",
							"skip to seventeen labial"
						},
						Action=VoiceCommandAction.SkipToTootSeventeenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth eighteen labial",
							"skip to eighteen labial"
						},
						Action=VoiceCommandAction.SkipToToothEighteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth nineteen labial",
							"skip to nineteen labial"
						},
						Action=VoiceCommandAction.SkipToToothNineteenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty labial",
							"skip to twenty labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty one labial",
							"skip to twenty one labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyOneLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty two labial",
							"skip to twenty two labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyTwoLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty three labial",
							"skip to twenty three labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyThreeLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty four labial",
							"skip to twenty four labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFourLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty five labial",
							"skip to twenty five labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyFiveLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty six labial",
							"skip to twenty six labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentySixLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty seven labial",
							"skip to twenty seven labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentySevenLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty eight labial",
							"skip to twenty eight labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyEightLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth twenty nine labial",
							"skip to twenty nine labial"
						},
						Action=VoiceCommandAction.SkipToToothTwentyNineLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty labial",
							"skip to thirty labial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty one labial",
							"skip to thirty one labial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyOneLabial,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip to tooth thirty two labial",
							"skip to thirty two labial"
						},
						Action=VoiceCommandAction.SkipToToothThirtyTwoLabial,
						Area=VoiceCommandArea.PerioChart
					},


#endregion PerioChart
				};
			}
		}
	}
}
