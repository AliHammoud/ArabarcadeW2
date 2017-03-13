using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow)) {

			Debug.Log("ok");
			GetComponent<Rigidbody>().AddForce(new Vector3(100,0,0));

		}

		if(Input.GetKey(KeyCode.LeftArrow)) {

			Debug.Log("ok");
			GetComponent<Rigidbody>().AddForce(new Vector3(-100,0,0));

		}

		if(Input.GetKeyDown(KeyCode.UpArrow)) {

			Debug.Log("ok");
			GetComponent<Rigidbody>().AddForce(new Vector3(0,25,0), ForceMode.Impulse);

		}

	}
}
