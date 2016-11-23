using System;
using System.Collections.Generic;

namespace VoiceCommand {
	public class VoiceCommand {
		public List<string> Commands;
		public VoiceCommandAction Action;
		public VoiceCommandArea Area=VoiceCommandArea.Global;
	}	

	public enum VoiceCommandAction {
		SelectPatient,
		GoToChartModule,
		GoToAppointmentModule,
		GoToFamilyModule,
		GoToAccountModule,
		GoToTreatmentPlanModule,
		GoToImageModule,
		GoToManageModule,
		CreateCommlog,
		SendEmail,
		CreatePatientForm,
		CreatePatientPayment,
		OpenPerioChart,
		CreatePerioChart,
		Two,
		One,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Eleven,
		Twelve,
		Thirteen,
		Fourteen,
		Fifteen,
		Sixteen,
		Seventeen,
		Eightteen,
		Nineteen,
		Zero,
		Triplet,
		Bleeding,
		Calculus,
		Suppuration,
		Plaque,
		Backspace,
		Skip,
		Left,
		Right,
		Delete,
		CopyPrevious,
		StartListening,
		StopListening,
	}

	[Flags]
	public enum VoiceCommandArea {
		Global=0,
		PerioChart=1,
		FormOpenDental = 2
	}
}
