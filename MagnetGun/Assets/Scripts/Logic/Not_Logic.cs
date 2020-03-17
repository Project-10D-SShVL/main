using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Not_Logic : MonoBehaviour {

	public Element_Logic logicIn;
	public Element_Logic logicOut;
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void FixedUpdate () {
			if (logicIn) {
				logicOut.value = !logicIn.value;
			}
		}
	}
