using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnionManager : MonoBehaviour {
	

	public float speed;
	public float baseSpeed;

	public int NumOfOnions;

	public GameObject llamaBoy;

	public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateOnionBoys ();

		if (NumOfOnions <= 0){
			speed = baseSpeed;
		}
		
	}

	void OnCollisionEnter2D (Collision2D llamaHittingme){
		if (llamaHittingme.gameObject.tag == "Player") {
			NumOfOnions = NumOfOnions + 1;
			speed = speed * 1.5f;

		}
	}

	void UpdateOnionBoys () {
		scoreText.text = "Bloomin' Onions: " + NumOfOnions;
	}
}
