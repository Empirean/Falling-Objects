using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float spawnInterval = 1f;
    public float spawnSizeMinMax = 2;
    public float spawnAngleMax = 5;
    public GameObject fallingObject;
   
    
    float nextSpawn;
    Vector2 dimens;

	void Start ()
    {
        dimens = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}

	void Update () {
		if (Time.time > nextSpawn)
        {
            Vector2 spawnPoint = new Vector2(Random.Range(-dimens.x, dimens.x), dimens.y + transform.localScale.y);
            float spawnSize = Random.Range(1, spawnSizeMinMax);
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);

            GameObject obstacle = (GameObject) Instantiate(fallingObject,spawnPoint, Quaternion.Euler(Vector3.forward * spawnAngle));
            obstacle.transform.localScale =  Vector2.one * spawnSize;


            nextSpawn = Time.time + spawnInterval;
        }
	}

   
}
