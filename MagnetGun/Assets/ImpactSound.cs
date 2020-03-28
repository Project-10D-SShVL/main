using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour {
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.relativeVelocity.magnitude > 1 && col.collider.gameObject.tag != "Player") {
			sound.Play ();
		}
	}
}
