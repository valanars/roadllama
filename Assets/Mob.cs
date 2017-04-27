using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour {


	public OnionManager onionManager;
	public Llama playerManager;

	public GameObject llama;

	public float baseOffset;
	public float offset;



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
			offset = 3f;
		}

		transform.position = currentPos;
		
	}
}
