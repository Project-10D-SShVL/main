using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner_Logic : MonoBehaviour {
	public GameObject cube;
	public Element_Logic logic;
	private GameObject cubeInstance;
	// Use this for initialization
	void Start () {
		StartCoroutine (Spawning ());
	}
	
	IEnumerator Spawning(){
		while (true) {
			if (logic.value) {
				if (cubeInstance) {
					Destroy (cubeInstance);
				}
				cubeInstance = Instantiate (cube, transform.position, Quaternion.identity);
				MetalPiecesList.instance.metalPieces = GameObject.FindGameObjectsWithTag("Metal");
				yield return new WaitForSeconds (2);
			}
			yield return new WaitForSeconds (0.01f);
		}
	}
}
