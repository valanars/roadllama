using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnionManager : MonoBehaviour {
	

	public float speed;
	public float baseSpeed;

	public int NumOfOnions;

	float Timer = 0.0f;

	public GameObject llamaBoy;

	public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		UpdateTime ();

		if (NumOfOnions <= 0){
			speed = baseSpeed;
		}
		
	}

	void OnCollisionEnter2D (Collision2D llamaHittingme){
		if (llamaHittingme.gameObject.tag == "Player") {
			NumOfOnions = NumOfOnions + 1;
			speed = speed * 1.5f;
			Timer = Timer * 1.5f;
		}
	}

	void UpdateTime () {
		scoreText.text = "Time: " + Timer;
	}
}
