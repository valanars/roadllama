using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrounds : MonoBehaviour {

	public Llama player;

	public GameObject background;
	public float offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D triggerHittingMe){
		Vector3 currentPos = transform.position;

		if (triggerHittingMe.gameObject.tag == "Player" && player.pastFirstScreen == true){
			currentPos.x = currentPos.x + offset;
		}

		transform.position = currentPos;
	}
}
