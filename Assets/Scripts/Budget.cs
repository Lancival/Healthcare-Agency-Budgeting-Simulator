using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Budget : MonoBehaviour {
	[SerializeField] private string n;

    // Start is called before the first frame update
    void Start() {
    	//transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = GetBudget().ToString();
    }

    // Update is called once per frame
    void Update() {
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = GetBudget().ToString();
    }

    int GetBudget() {
    	if (n == "Operations")
    		return Globals.Operations();
    	else
    		return 0;
    }
}
