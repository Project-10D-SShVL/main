using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewLevelButton_Logic : MonoBehaviour {
	public string level;
	public Element_Logic logic;
	public void Load(){
		SceneManager.LoadScene(level, LoadSceneMode.Single);
		Time.timeScale = 1;
	}
	// Use this for initialization
	void Start () {

	}


	void FixedUpdate(){
		if (logic.value) {
			SceneManager.LoadScene(level, LoadSceneMode.Single);
		}
	}
}

