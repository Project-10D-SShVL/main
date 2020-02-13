using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScript : MonoBehaviour {
	public string level;
	// Use this for initialization
	void Start () {

	}


	void FixedUpdate(){

		SceneManager.LoadScene(level, LoadSceneMode.Single);
	
	}
}

