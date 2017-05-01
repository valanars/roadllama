using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour {


	public bool Menu;

	public bool playHover = true;
	public bool creditHover = false;
	public bool controlHover = false;

	public Sprite[] playSelect;
	public SpriteRenderer playButton;
	public Sprite[] creditSelect;
	public SpriteRenderer creditButton;
	public Sprite[] controlSelect;
	public SpriteRenderer controlButton;



	// Use this for initialization
	void Start () {
		playButton.sprite = playSelect [1];
		creditButton.sprite = creditSelect [0];
		controlButton.sprite = controlSelect [0];
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;


		if (playHover == true && Input.GetKeyUp (KeyCode.LeftArrow)){
			playHover = false;
			creditHover = true;
			playButton.sprite = playSelect [0];
			creditButton.sprite = creditSelect [1];
			controlButton.sprite = controlSelect [0];
		} else if (playHover == false && creditHover == true && Input.GetKeyUp (KeyCode.RightArrow)){
			playHover = true;
			creditHover = false;
			playButton.sprite = playSelect [1];
			creditButton.sprite = creditSelect [0];
			controlButton.sprite = controlSelect [0];
		} else if (playHover == true && Input.GetKeyUp (KeyCode.RightArrow)){
			playHover = false;
			controlHover = true;
			playButton.sprite = playSelect [0];
			creditButton.sprite = creditSelect [0];
			controlButton.sprite = controlSelect [1];
		} else if (playHover == false && controlHover == true && Input.GetKeyUp (KeyCode.LeftArrow)){
			playHover = true;
			controlHover = false;
			playButton.sprite = playSelect [1];
			creditButton.sprite = creditSelect [0];
			controlButton.sprite = controlSelect [0];
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

		if (Menu == false && Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel ("Start");
		}
		
	}
}
