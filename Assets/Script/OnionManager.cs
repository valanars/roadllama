using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnionManager : MonoBehaviour {
	

	public float speed;
	public float baseSpeed;

	public int NumOfOnions;

	float Timer = 0.0f;

	public Llama player;
	public Mob mobManager;

	public GameObject llamaBoy;

	public Text scoreText;

	public Sprite[] topButton;
	public SpriteRenderer firstButton;
	public Sprite[] bottomButton;
	public SpriteRenderer secondButton;
	public bool restart = false;
	public bool mainMenu = false;


	// Use this for initialization
	void Start () {
		firstButton.sprite = topButton [0];
		secondButton.sprite = bottomButton [0];
		
	}
	
	// Update is called once per frame
	void Update () {

		UpdateTime ();

		if(mobManager.gameOver == false){
		
		Timer += Time.deltaTime;

	

		if (NumOfOnions <= 0){
			speed = baseSpeed;
		}

		if (speed >= 15f){
			speed = 15f;
		}
		} else if (mobManager.gameOver == true){
			speed = 0;
		}

		if (mobManager.gameOver == true){
			firstButton.sprite = topButton [1];
			secondButton.sprite = bottomButton [1];
			restart = true;
		}

			


	}

	void OnCollisionEnter2D (Collision2D llamaHittingme){
		if (llamaHittingme.gameObject.tag == "Player") {
			NumOfOnions = NumOfOnions + 1;
			//speed = speed + .1f;
			Timer = Timer * 1.5f;
		}
	}

	void UpdateTime () {
		scoreText.text = "Score: " + Timer;
	}
}
