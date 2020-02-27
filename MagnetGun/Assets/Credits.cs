using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
	// Use this for initialization
	public float speed;
	public float delay;
	void Start () {
		StartCoroutine (Moving());
	}
	IEnumerator Moving(){
		yield return new WaitForSecondsRealtime (delay);
		while (true) {
			gameObject.transform.Translate (Vector3.up * 0.002f * speed);
			yield return new WaitForSecondsRealtime(0.002f);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
