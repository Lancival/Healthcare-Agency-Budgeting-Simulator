using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Budget : MonoBehaviour {
	[SerializeField] private string n;     // Name of budget subtotal/total to retrieve
    [SerializeField] private int r;        // Region number if applicable

    // Update is called once per frame
    void Update() {
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = GetBudget().ToString();
    }

    int GetBudget() {
    	if (n == "Operations")
    		return Globals.Operations();
        else if (n == "Research")
            return Globals.Research();
        else if (n == "International Health")
            return Globals.InternationalHealth();
        else if (n == "Miscellaneous") 
            return Globals.Miscellaneous();
        else if (n == "Region")
            return Globals.Region(r);
        else if (n == "Total")
            return Globals.Total();
    	else {
    		Debug.Log("Error: Attempted to retrieve nonexistent part of budget in Budget.cs!");
            return 0;
        }
    }
}
