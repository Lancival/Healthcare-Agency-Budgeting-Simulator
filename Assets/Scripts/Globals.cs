using System.Collections;
using System.Collections.Generic;

static class Globals {
	public static float volume = 1.0f;
	public static int difficulty = 1;				// 0,1,2 = easy,normal,hard?
	public static int original_budget = 7178;		// Starting budget of quarter 1
	public static int starting_budget;				// Maximum amount that can be spent this quarter
	public static Dictionary<string,int> budget = new Dictionary<string, int>();	// Allocated budget for each item
	public static int quarter = 1;				// Current quarter number
}
