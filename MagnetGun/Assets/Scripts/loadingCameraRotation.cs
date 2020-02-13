using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingCameraRotation : MonoBehaviour {
		public GameObject cam;
		public float sensitivity;
		public float clampAngle;
		float rotX = 0f;
		float rotY = 0f;
		List<Collider> col = new List<Collider>();

		void FixedUpdate(){
			rotY += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
			rotX -= Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;
			rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
			cam.transform.localRotation = Quaternion.Euler(rotX, 0f , 0.0f);
			transform.rotation = Quaternion.Euler(0f, rotY , 0.0f);
		}
		// Use this for initialization
		void Start () {

		}
	}
