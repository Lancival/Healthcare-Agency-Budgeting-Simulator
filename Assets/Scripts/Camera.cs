using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	[SerializeField] private float speed = 1.0f;

    void Update() {
     if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 2.5)
         transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
     if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -2.5)
         transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
     if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -2.5)
         transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
     if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 2.5)
         transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
     }
}
