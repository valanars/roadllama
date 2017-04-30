using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour {


	public OnionManager onionManager;
	public Llama playerManager;

	public GameObject llama;

	public float baseOffset;
	public float offset;

	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;
		currentPos.x = llama.transform.position.x - offset;
			
		if (playerManager.hitObstacle <= 0) {
			offset = baseOffset;
		} else if (playerManager.hitObstacle > 0 && playerManager.hitObstacle <= 1) {
			offset = 5f;
		} else if (playerManager.hitObstacle > 1 && playerManager.hitObstacle <= 2) {
			offset = 4f;
		} else if (playerManager.hitObstacle > 2 && playerManager.hitObstacle <= 3) {
			offset = 3f;
		} else if (playerManager.hitObstacle > 3 && playerManager.hitObstacle <= 4) {
			offset = 2f;
		} else if (playerManager.hitObstacle > 4 && playerManager.hitObstacle <= 5) {
			offset = 1f;
		} else if (playerManager.hitObstacle > 5) {
			gameOver = true;
		}

		transform.position = currentPos;
		
	}
}
