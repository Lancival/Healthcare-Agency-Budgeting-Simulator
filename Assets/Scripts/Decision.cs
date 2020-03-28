using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Decision : MonoBehaviour {
	private int max_funding = 2;
	private int funding = 2;
	[SerializeField] private int[] cost;
	[SerializeField] private string[] description;

	void Start() {
		Globals.budget.Add(name, cost[2]);
		for (int i = 0; i < 3; i++)
			transform.GetChild(1).GetChild(i).GetComponent<Button>().onClick.AddListener(ButtonClick);
		UpdateUI();
	}

	void ButtonClick() {
		funding = EventSystem.current.currentSelectedGameObject.transform.GetSiblingIndex();
		Globals.budget[name] = cost[funding];
		UpdateUI();
	}

	private void UpdateUI() {
		SetButtons();
		UpdateCost();
		UpdateDescription();
	}

	private void UpdateCost() {
		transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().text = cost[funding].ToString();
	}

	private void UpdateDescription() {
		transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = description[funding];
	}

	private void SetButtons() {
		for (int i = 0; i < 3; i++) {
			if (i != funding)
				transform.GetChild(1).GetChild(i).GetComponent<Button>().interactable = true;
			else
				transform.GetChild(1).GetChild(i).GetComponent<Button>().interactable = false;
		}
	}

}
