using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionBoys : MonoBehaviour {


	public float startX;

	public Llama playerManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;

		if (playerManager.respawning == true) {
			currentPos.x = startX;
		}

		transform.position = currentPos;
		
	}

	void OnTriggerEnter2D (Collider2D gameObjectHittingMe){
		Vector3 currentPos = transform.position;
		int randomIndex = Random.Range(11,25);

		if (gameObjectHittingMe.gameObject.tag == "Player"){
			currentPos.x = currentPos.x + randomIndex;
			Debug.Log ("ONION BOYS");
			//Destroy (gameObject);

		}

		transform.position = currentPos;
	}
}
