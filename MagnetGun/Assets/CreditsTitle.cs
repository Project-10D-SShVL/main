using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsTitle : MonoBehaviour {
	public TextMesh textM;
	// Use this for initialization
	void Start () {
		StartCoroutine (Appearing());
	}
	IEnumerator Appearing(){
		while (textM.color.a < 1) {
			float txtColor = Mathf.Clamp01((float)(textM.color.a + 0.002));
			textM.color = new Color(txtColor, txtColor, txtColor, txtColor);
			yield return new WaitForSecondsRealtime (0.002f);
		}
		Debug.Log("Done");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
