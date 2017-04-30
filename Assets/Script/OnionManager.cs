using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnionManager : MonoBehaviour {
	

	public float speed;
	public float baseSpeed;

	public int NumOfOnions;

	public float Timer = 0.0f;

	public Llama player;
	public Mob mobManager;
	public Cursor cursor;

	public GameObject llamaBoy;

	public Text scoreText;

	public Sprite[] topButton;
	public SpriteRenderer firstButton;
	public Sprite[] bottomButton;
	public SpriteRenderer secondButton;
	public Sprite[] overText;
	public SpriteRenderer activeText;



	// Use this for initialization
	void Start () {
		firstButton.sprite = topButton [0];
		secondButton.sprite = bottomButton [0];
		activeText.sprite = overText [0];
		
	}
	
	// Update is called once per frame
	void Update () {

		UpdateTime ();

	if (mobManager.gameOver == false){
		
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

		if (mobManager.gameOver == true && cursor.restartHover == true){
			firstButton.sprite = topButton [1];
			secondButton.sprite = bottomButton [1];
			activeText.sprite = overText [1];
		} else if (mobManager.gameOver == true && cursor.menuHover == true){
			firstButton.sprite = topButton [2];
			secondButton.sprite = bottomButton [2];
			activeText.sprite = overText [1];
		}

	}

	void OnCollisionEnter2D (Collision2D llamaHittingme){
		if (llamaHittingme.gameObject.tag == "Player") {
			NumOfOnions = NumOfOnions + 1;
			Timer = Timer * 1.5f;
		}
	}

	void UpdateTime () {
		scoreText.text = "Score: " + Timer;
	}
}
