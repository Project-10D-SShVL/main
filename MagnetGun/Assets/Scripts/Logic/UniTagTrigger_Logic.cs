using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniTagTrigger_Logic : MonoBehaviour {
	public Element_Logic logic;
	public string Tag;
	List<Collider> cols = new List<Collider>();
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		logic.value = cols.Count > 0;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == Tag) {
			cols.Add (other);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == Tag) {
			cols.Remove (other);
		}
	}
}
