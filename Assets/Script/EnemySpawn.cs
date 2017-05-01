using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;
    public GameObject shootingPoint;

	public float numOfEnemies;


   
    public float enemyTimer;
    public float enemyCoolDown = 1f;          


    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	
	void Update () {
        



		Spawning();
	}

    void Spawning()
    {
		int randomIndex = Random.Range(9,17);
        enemyTimer += Time.deltaTime;         

		if (enemyTimer >= enemyCoolDown)
        {
			
			GameObject newObject = Instantiate (enemy) as GameObject;
			SpriteRenderer objSprite = newObject.GetComponent<SpriteRenderer> ();
			Rigidbody2D enemySprite = newObject.GetComponent<Rigidbody2D> ();
			Vector3 newObjPos = newObject.transform.position;
			newObjPos.x = player.transform.position.x + randomIndex;
			newObjPos.y = -4.94f;
			newObject.transform.position = newObjPos;

			enemyTimer = 0;

        }
			

    }
}
