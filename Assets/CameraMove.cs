using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {


	public GameObject player;
	public float offsetX;
	public float offsetY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPos = transform.position;

		currentPos = player.transform.position;


		transform.position = new Vector3 (currentPos.x + offsetX, -0.95f, -7.2f);//currentPos;
	}
}
