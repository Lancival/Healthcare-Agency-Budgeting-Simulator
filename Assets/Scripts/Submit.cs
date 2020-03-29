using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Submit : MonoBehaviour {
	private Button b;

    void Start() {
    	Globals.starting_budget = Globals.original_budget;
    	b = transform.GetComponent<Button>();
    	b.onClick.AddListener(SubmitBudget);
    	b.interactable = false;
    }

    void Update() {
    	if (Globals.starting_budget >= Globals.Total())
    		b.interactable = true;
    }

    void SubmitBudget() {
    	Globals.quarter++;
    	Globals.starting_budget = (int) (Globals.Total() * (1.0f - (float)(Globals.difficulty) / 10.0f));
    	b.interactable = false;
    	UpdateLetter();
    }

    void UpdateLetter() {
    	GameObject.Find("Letter").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Quarter " + Globals.quarter.ToString();
    	// Update the contents of the letter to reflect your decisions
    	return;
    }
}
