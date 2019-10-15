using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Vector2 speedMinMax;
    float speed;

    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
    }

    void Update ()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y + (transform.localScale.y / 2) <  -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
	}
}
