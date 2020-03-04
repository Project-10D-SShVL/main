using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour {
	public float distance;
	public Camera cam;
	// Use this for initialization
	void Start () {
		StartCoroutine(Interacting());
	}
	
	// Update is called once per frame
	IEnumerator Interacting () {
		while (true) {
			if (Input.GetKey (KeyCode.E)) {
				RaycastHit hit;
				Ray ray = cam.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit)) {
					Transform objectHit = hit.transform.root;

					Element_Logic logic = objectHit.gameObject.GetComponent<Element_Logic> ();
					if ((hit.transform.gameObject.tag == "Interactable") && logic) {
						logic.value = true;
					}
				}
			}

				yield return new WaitForSeconds (0.01f);
			
		}
	}
}
