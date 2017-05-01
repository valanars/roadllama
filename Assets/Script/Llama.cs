using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llama : MonoBehaviour {

	Rigidbody2D playerSprite;
	public float score = 0;

	public OnionManager onionManager;
	public Mob mobManager;

	public GameObject dust;
	public GameObject respawn;
	public GameObject mob;

	public bool respawning;
	public bool pastFirstScreen = false;

	public int numberOfOnions;
	public int hitObstacle;

	bool grounded;

	public float jumpHeight;

	public Animator playerAnim;

	// Use this for initialization
	void Start () {
		playerSprite = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		playerAnim.SetBool ("Grounded", grounded);

		Vector3 currentPos = transform.position;

		 if (respawning == true && numberOfOnions <= 0){
			currentPos.x += 0 * onionManager.speed * Time.deltaTime;
			score = score + 0 * Time.deltaTime;
		}
			
		if(mobManager.gameOver == false){

		if (grounded == true && Input.GetKeyDown (KeyCode.Space)){
			playerSprite.AddForce(transform.up*jumpHeight,ForceMode2D.Impulse);
			grounded = false;
		} else if (grounded == false && Input.GetKeyDown (KeyCode.Space)){
			playerSprite.AddForce (transform.up * -1 * jumpHeight, ForceMode2D.Impulse);
		}
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

		if (triggerHittingme.gameObject.tag == "Obstacle" && mobManager.gameOver == false){
			hitObstacle = hitObstacle + 1;
			onionManager.Timer = onionManager.Timer - 50f;
			Camera.main.GetComponent<ScreenShake> ().Shake ();
		}

		if (triggerHittingme.gameObject.tag == "Onion" && mobManager.gameOver == false) {
			onionManager.NumOfOnions = onionManager.NumOfOnions + 1;
			onionManager.speed = onionManager.speed + .5f;
			onionManager.Timer = onionManager.Timer + 30f;

		}
			
	}


}
