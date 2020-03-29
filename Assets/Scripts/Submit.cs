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
    	if (Globals.disease == false)
    		Globals.starting_budget = (int) (Globals.Total() * (1.0f - (float)(Globals.difficulty) / 10.0f));
    	b.interactable = false;
    	UpdateLetter();
    }

    void UpdateLetter() {
    	GameObject.Find("Letter").transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Quarter " + Globals.quarter.ToString();

    	string letter = "Quarterly Report\n\n";
    	if (Globals.disease == false)
    		letter += "Once again, the Ministry of Health's budget is being reduced. More programs and services will have to be cut back or eliminated.\n\n";
    	else
    		letter += "With the emergence of a deadly new disease in the population, the Ministry of Health's budget is not being slashed this quarter. However, resources will need to be diverted from other programs to pay for outbreak control.\n\n";
    	GameObject.Find("Letter").transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = letter;
    	// Update the contents of the letter to reflect your decisions
    	return;
    }
}
