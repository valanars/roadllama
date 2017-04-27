using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour {


	public bool start;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)){
			Application.LoadLevel ("Main Level");
		}
		
	}
}
