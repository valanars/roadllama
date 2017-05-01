using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

	public bool restartHover = true;
	public bool menuHover = false;
	public Mob mob;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;

		if (Input.GetKey (KeyCode.DownArrow)) {
			currentPos.y = -0.36f;
			menuHover = true;
			restartHover = false;

		} else if (Input.GetKey (KeyCode.UpArrow)) {
			currentPos.y = -2.54f;
			menuHover = false;
			restartHover = true;
		}
		transform.position = currentPos;

		if (menuHover == true && (Input.GetKeyDown (KeyCode.Return)) && mob.gameOver == true) {
			Application.LoadLevel ("Start");
		} else if (restartHover == true && (Input.GetKeyDown (KeyCode.Return)) && mob.gameOver == true){
			Application.LoadLevel ("Main Level");
		}

	}
}
