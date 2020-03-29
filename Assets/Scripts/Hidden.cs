using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour {
	private GameObject child;
    // Start is called before the first frame update
    void Start() {
        child = transform.GetChild(0).gameObject;
        child.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Globals.disease == true)
        	child.SetActive(true);
    }
}
