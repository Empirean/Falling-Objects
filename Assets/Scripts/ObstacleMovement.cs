using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Vector2 speedMinMax;
    float speed;

    float visibleHeightThreshold;

    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    void Update ()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y  <  visibleHeightThreshold)
        {
            Destroy(gameObject);
        }
	}
}
