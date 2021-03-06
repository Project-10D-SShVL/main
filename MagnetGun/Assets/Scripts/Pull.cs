﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour {
	public Transform t;
	public float force;
	private float len;
	GameObject[] pieces;
	GameObject minObj;
	float minD;
	// Use this for initialization
	void Start () {
		
		pieces = MetalPiecesList.instance.metalPieces;
		minObj = pieces [0];
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (!minObj) {
			minObj = MetalPiecesList.instance.metalPieces [0];
		}
		minD = Mathf.Abs ((Camera.main.WorldToScreenPoint (minObj.transform.position) - new Vector3 (Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2)).magnitude);
		//Debug.Log (minD);
		foreach (GameObject piece in MetalPiecesList.instance.metalPieces) {
			if (piece) {
				len = Mathf.Abs ((Camera.main.WorldToScreenPoint (piece.transform.position) - new Vector3 (Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2)).magnitude);
				if (len < minD) {
					minD = len;
					minObj = piece;
				}
			}

		}
		t = minObj.transform;
		Debug.Log (minObj.name);
		Debug.Log (MetalPiecesList.instance.metalPieces.Length);
		if (Input.GetKey (KeyCode.Mouse1) & minD < 150) {
			gameObject.GetComponent<Rigidbody> ().AddForce ((-(transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
			Rigidbody rb = t.gameObject.GetComponent<Rigidbody> ();
			if (rb) {
				rb.AddForce (((transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
			}
		} else {

			if (Input.GetKey (KeyCode.Mouse1)) {
				var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit Hit;
				if (Physics.Raycast (ray, out Hit) && Hit.collider.gameObject.tag == "Metal") {
					gameObject.GetComponent<Rigidbody> ().AddForce ((-(transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
					Rigidbody rb = Hit.collider.gameObject.GetComponent<Rigidbody> ();
					if (rb) {
						rb.AddForce (((transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
					}
					Debug.Log ("rayHit");

				}
			}
		}
	}
}
