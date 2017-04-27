using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

	public GameObject player;
	public float offsetX;
	public float offsetY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shake(){
		StartCoroutine ("Screenshaker");
	}

	public IEnumerator Screenshaker(){


		float time = .15f;

		while (time > 0.0f) {
			Debug.Log (time);
			Camera.main.transform.position = new Vector3 (player.transform.position.x + offsetX, -0.95f, -7.2f) + (Vector3)Random.insideUnitCircle + Vector3.back * -2.0f;
			time -= Time.deltaTime;
			yield return 0;
		}
		Camera.main.transform.position = new Vector3 (player.transform.position.x + offsetX, -0.95f, -2.0f);

		//	Camera.main.GetComponent<ScreenShake> ().Shake ();
		//that goes in your player script probably
	}
}
