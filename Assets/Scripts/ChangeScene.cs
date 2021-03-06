﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {
	[SerializeField] private string scene_name; // Name of the scene that the button will change to

    // Start is called before the first frame update
    void Start() {
        gameObject.GetComponent<Button>().onClick.AddListener(Load); // At the start, make the button call load() when clicked
    }

    void Load() {
        SceneManager.LoadScene(scene_name); // Switch to the scene with the correct name
    }
}
