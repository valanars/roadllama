using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	public OnionManager onions;

	public float tileSizeZ;

	private Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{


		float newPosition = Mathf.Repeat(Time.time * onions.speed, tileSizeZ);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}

