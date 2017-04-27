using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	bool gamePaused = false;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (gamePaused == false && Input.GetKeyUp (KeyCode.P)) {
			gamePaused = true;
			Time.timeScale = 0.0f;
		} else if (gamePaused == true && Input.GetKeyUp (KeyCode.P)) {
			Time.timeScale = 1.0f;
			gamePaused = false;
		}
			
	}
}


