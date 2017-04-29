using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llama : MonoBehaviour {

	Rigidbody2D playerSprite;
	public float score = 0;

	public OnionManager onionManager;

	public GameObject dust;
	public GameObject respawn;
	public GameObject mob;

	public bool respawning;
	public bool pastFirstScreen = false;

	public int numberOfOnions;
	public int hitObstacle;

	bool grounded;

	public float jumpHeight;
	//public float moveSpeed;

	// Use this for initialization
	void Start () {
		playerSprite = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {


		//Debug.Log (score);
		Vector3 currentPos = transform.position;



//		if (Input.GetKey (KeyCode.RightShift)) {
//			currentPos.x += 1.5f * onionManager.speed * Time.deltaTime;
//
//		} 

		if (respawning == false){
			currentPos.x += onionManager.speed * Time.deltaTime;
			score = score + Time.deltaTime; //score increases over time
		} else if (respawning == true && numberOfOnions <= 0){
			currentPos.x += 0 * onionManager.speed * Time.deltaTime;
			score = score + 0 * Time.deltaTime;
		}



		if (grounded == true && Input.GetKeyDown (KeyCode.Space)){
			playerSprite.AddForce(transform.up*jumpHeight,ForceMode2D.Impulse);
			grounded = false;
		}

		transform.position = currentPos;
		
	}

	void OnCollisionEnter2D (Collision2D gameObjectHittingMe){
		Vector3 currentPos = transform.position;

		if (gameObjectHittingMe.gameObject.tag == "Floor") {
			grounded = true;
			GameObject newObject = Instantiate (dust) as GameObject;
			Vector3 newObjPos = newObject.transform.position;
			newObjPos.x = currentPos.x;
			newObjPos.y = currentPos.y;
			newObject.transform.position = newObjPos;
		} 

		if(gameObjectHittingMe.gameObject.tag == "Floor" && respawning == true){
			respawning = false;
		}


		if (gameObjectHittingMe.gameObject.tag == "end"){
			currentPos.x = respawn.transform.position.x;
			currentPos.y = respawn.transform.position.y;
			respawning = true;
			onionManager.NumOfOnions = 0;

		}

		transform.position = currentPos;
	}

	void OnTriggerEnter2D (Collider2D triggerHittingme){

		if (triggerHittingme.gameObject.tag == "Obstacle"){
			score = score - 5f;
			hitObstacle = hitObstacle + 1;
			//	Debug.Log ("lmao rip");
			Camera.main.GetComponent<ScreenShake> ().Shake ();
		}

		if (triggerHittingme.gameObject.tag == "Onion") {
			onionManager.NumOfOnions = onionManager.NumOfOnions + 1;
			onionManager.speed += onionManager.speed + .1f;
			score = score + 1.5f * Time.deltaTime;
		}

		if (triggerHittingme.gameObject.tag == "marker"){
			pastFirstScreen = true;
		}
	}


}
