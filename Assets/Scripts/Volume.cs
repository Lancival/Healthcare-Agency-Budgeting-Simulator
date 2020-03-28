using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {

	private AudioSource sound;
	[SerializeField] private bool PlayOnStart; 

    void Start() {
        sound = gameObject.GetComponent<AudioSource>();
        sound.volume = Globals.volume;
        if (PlayOnStart)
        	sound.Play(0);
    }
}
