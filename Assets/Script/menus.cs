using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour {


	public bool Menu;
	public bool Credits;
	public bool Controls;

	public bool playHover = true;
	public bool creditHover = false;
	public bool controlHover = false;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;


		if (playHover == true && Input.GetKeyUp (KeyCode.LeftArrow)){
			playHover = false;
			creditHover = true;
		} else if (playHover == false && creditHover == true && Input.GetKeyUp (KeyCode.RightArrow)){
			playHover = true;
			creditHover = false;
		} else if (playHover == true && Input.GetKeyUp (KeyCode.RightArrow)){
			playHover = false;
			controlHover = true;
		} else if (playHover == false && controlHover == true && Input.GetKeyUp (KeyCode.LeftArrow)){
			playHover = true;
			controlHover = false;
		}


			

		transform.position = currentPos;

		if (playHover == true && Input.GetKeyDown (KeyCode.Return)){
			Application.LoadLevel ("Main Level");
		} 
		if (creditHover == true && Input.GetKeyDown (KeyCode.Return)){
			Application.LoadLevel ("Credits");
		}
		if (controlHover == true && Input.GetKeyDown (KeyCode.Return)) {
			Application.LoadLevel ("Controls");
		}
		
	}
}
