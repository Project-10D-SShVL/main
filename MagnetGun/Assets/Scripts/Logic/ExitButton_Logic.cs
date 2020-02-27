using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton_Logic : MonoBehaviour {
	public Element_Logic logic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(logic.value){
			Application.Quit();
		}
	}
}
