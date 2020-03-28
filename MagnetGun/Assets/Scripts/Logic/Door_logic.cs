using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_logic : MonoBehaviour {
	public Element_Logic logic;
	public Animator anim;
	public AudioSource soundOpen;
	public bool mute;
	private string ps = "Closed";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetBool("isOpen", logic.value);
		if (!mute) {
			if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Opening")) {
				if (ps != "Opening") {
					ps = "Opening";
					soundOpen.Play ();
				}
			}
			if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Closing")) {
				if (ps != "Closing") {
					ps = "Closing";
					soundOpen.Play ();
				}
			}
			if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Open")) {
				if (ps != "Open") {
					ps = "Open";
				}
			}
			if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Closed")) {
				if (ps != "Closed") {
					ps = "Closed";
				}
			}
		}
	}
}
