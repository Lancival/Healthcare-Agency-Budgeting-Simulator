using System.Collections;
using System.Collections.Generic;

static class Globals {
	public static float volume = 1.0f;
	public static int difficulty = 1;												// 0,1,2 = easy,normal,hard?
	public static int original_budget = 7178;										// Starting budget of quarter 1
	public static int starting_budget;												// Maximum amount that can be spent this quarter
	public static Dictionary<string,int> budget = new Dictionary<string, int>();	// Allocated budget for each item
	public static int quarter = 1;													// Current quarter number
	public static bool disease = false;

	public static int Operations() {
		return budget["Media Monitoring"] + budget["Health and Safety Inspections"] + budget["Disease Response Team"] + budget["Supply Stockpile Program"];
	}

	public static int Research() {
		return budget["Mental Health Division"] + budget["Antibiotic Resistance Team"] + budget["Cancer Prevention and Treatment"] + budget["Gun Violence Studies"];
	}

	public static int InternationalHealth() {
		return budget["International Relations"] + budget["Foreign Aid Program"] + budget["Disease Eradication"];
	}

	public static int Miscellaneous() {
		return budget["Administrative Staff"] + budget["Cleaning and Maintenance"] + budget["Travel Expenses"] + budget["Quarterly Retreat"];
	}

	public static int Region(int i) {
		if (i == 0)
			return Region(1) + Region(2) + Region(3) + Region(4);
		string region = "";
		if (i == 1)
			region = "Lake";
		else if (i == 2)
			region = "Mountain";
		else if (i == 3)
			region = "Forest";
		else if (i == 4)
			region = "Plains";
		else return 0;
		return budget[region + " Infrastructure"];
	}

	public static int OutbreakControl() {
		if (disease == false)
			return 0;
		else
			return budget["Vaccine Research"] + budget["Supply Procurement"] + budget["Contact Tracing"] + budget["Quarantine Enforcement"];
	}

	public static int Total() {
		return Region(0) + Operations() + Research() + InternationalHealth() + Miscellaneous() + OutbreakControl();
	}
}
