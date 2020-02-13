using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnObjClick : MonoBehaviour {

	public GameObject definedButton;
	public Element_Logic logic;
	// Use this for initialization
	void Start () {
		definedButton = this.gameObject;
	}

	// Update is called once per frame
	void FixedUpdate () {
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit Hit;

		if (Input.GetMouseButtonDown(0))
		{
			if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
			{
				Debug.Log("Button Clicked");
				logic.value = true;
			}
		}    
	}
}