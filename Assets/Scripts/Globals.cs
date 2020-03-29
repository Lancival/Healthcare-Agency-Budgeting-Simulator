using System.Collections;
using System.Collections.Generic;

static class Globals {
	public static float volume = 1.0f;
	public static int difficulty = 1;												// 0,1,2 = easy,normal,hard?
	public static int original_budget = 7178;										// Starting budget of quarter 1
	public static int starting_budget;												// Maximum amount that can be spent this quarter
	public static Dictionary<string,int> budget = new Dictionary<string, int>();	// Allocated budget for each item
	public static int quarter = 1;													// Current quarter number

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
		return 0;
	}

	public static int Total() {
		int total = 0;
		for (int i = 0; i < 4; i++)
			total += Region(i);
		return total + Operations() + Research() + InternationalHealth() + Miscellaneous();
	}
}
