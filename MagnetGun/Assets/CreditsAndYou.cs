using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsAndYou : MonoBehaviour {
	public Transform t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 0) {
			transform.parent = t;
			transform.position = Vector3.zero;
		}
	}
}
