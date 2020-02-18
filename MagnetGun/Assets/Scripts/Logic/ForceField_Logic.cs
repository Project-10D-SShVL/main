using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField_Logic : MonoBehaviour {
	public GameObject field;
	public Element_Logic logic;

	// Update is called once per frame
	void FixedUpdate () {
		field.SetActive (!logic.value);
	}
}
