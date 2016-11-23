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
							"back",
							"backspace"
						},
						Action=VoiceCommandAction.Backspace,
						Area=VoiceCommandArea.PerioChart
					},
					new VoiceCommand {
						Commands=new List<string> {
							"skip"
						},
						Action=VoiceCommandAction.Skip,
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
				};
			}
		}
	}
}
