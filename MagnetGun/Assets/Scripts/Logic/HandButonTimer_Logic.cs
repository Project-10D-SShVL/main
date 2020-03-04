using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandButonTimer_Logic : MonoBehaviour {
	public Element_Logic logic;
	public float activityTime;
	// Use this for initialization
	void Start () {
		StartCoroutine (Deactivating ());
	}
	
	IEnumerator Deactivating(){
		while (true) {
			if(logic.value){
				yield return new WaitForSeconds (activityTime);
				logic.value = false;
			}
			yield return new WaitForSeconds (0.01f);
		}
	}
}
