using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseScript : MonoBehaviour {
	// Use this for initialization
	private bool buttonPressed;
	public GameObject PauseMenu;
	public GameObject cursor;
	public void pressButton(){
		buttonPressed = true;
	}
	void Awake () {
		PauseMenu.SetActive (false);
		StartCoroutine (Pause ());
	}
	IEnumerator Pause(){
		while (true) {
			if (Input.GetKey (KeyCode.Escape) || buttonPressed) {
				buttonPressed = false;
				if (Time.timeScale == 0){
					PauseMenu.SetActive (false);
					cursor.SetActive (true);
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
					Time.timeScale = 1;
					Debug.Log ("unPaused");
				}
				else{
					PauseMenu.SetActive (true);
					cursor.SetActive (false);
					Cursor.visible = true;
					Cursor.lockState = CursorLockMode.Confined;
					Time.timeScale = 0;
					Debug.Log ("Paused");
				}
				yield return new WaitForSecondsRealtime (0.5f);
			}
			yield return new WaitForSecondsRealtime (0.01f);
		}
	}
}
