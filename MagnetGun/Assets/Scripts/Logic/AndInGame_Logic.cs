using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndInGame_Logic : MonoBehaviour {
	public Element_Logic logic1;
	public Element_Logic logic2;
	public Element_Logic logicOut;
	public bool value;
	public Material[] materials;
	public Renderer rend;
	private int m;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (logicOut) {
			value = logic1.value & logic2.value;
			logicOut.value = value;
			if(value){
				m = 1;
			}else{
				m = 0;
			}
			rend.sharedMaterial = materials[m];
		}
	}
}
