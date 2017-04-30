using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionBoys : MonoBehaviour {


	public float startX;
	public GameObject player;
	public Llama playerManager;
	public OnionManager onions;

	public bool notAnOnion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;

		currentPos.x -= onions.speed * Time.deltaTime;

		if (playerManager.respawning == true) {
			currentPos.x = startX;
		}

		transform.position = currentPos;
		
	}

	void OnTriggerEnter2D (Collider2D gameObjectHittingMe){
		Vector3 currentPos = transform.position;
		int randomIndex = Random.Range(11,25);

		if (gameObjectHittingMe.gameObject.tag == "Player" && notAnOnion == false){
			currentPos.x = currentPos.x + randomIndex;
			Debug.Log ("ONION BOYS");
		}

		if (gameObjectHittingMe.gameObject.tag == "Reset" && notAnOnion == true) {
			Destroy (gameObject);
		} else if (gameObjectHittingMe.gameObject.tag == "Reset" && notAnOnion == false) {
			currentPos.x = player.transform.position.x + randomIndex;
		}

		transform.position = currentPos;
	}
}
