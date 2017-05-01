using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {


	void Start(){

	}

	void Update()
	{
		DontDestroyOnLoad(this);

		if (FindObjectsOfType(GetType()).Length > 1){
			Destroy(gameObject);
		}
}
}