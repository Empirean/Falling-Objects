using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float speed = 7;

    void Update () {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y + (transform.localScale.y / 2) <  -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
	}
}
