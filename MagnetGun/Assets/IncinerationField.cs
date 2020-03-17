using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncinerationField : MonoBehaviour {
		public float x, y, z;
		public Transform trashRoom;
		void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			other.transform.position = new Vector3 (x, y, z);
			other.transform.rotation = Quaternion.identity;
		} else {
			other.transform.position = trashRoom.position;
		}
	}
}