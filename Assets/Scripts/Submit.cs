using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    	Globals.starting_budget = (int) (Globals.starting_budget * (1.0f - (float)(Globals.difficulty) / 10.0f));
    	UpdateLetter();
    }

    void UpdateLetter() {
    	// Update the contents of the letter to reflect your decisions
    	return;
    }
}
