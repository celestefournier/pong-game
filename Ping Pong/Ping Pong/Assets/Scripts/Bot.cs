using UnityEngine;
using System.Collections;

public class Bot : Player {

    Vector2 ball_pos;

    void Start () {
        ball = GameObject.Find("Ball");
        //Vector2 ball_pos = ball.transform.position;
        sizePlayer_y = GetComponent<BoxCollider2D>().size.y;
        velocidade = 7.5f;
    }
	
	void Update () {
        //Debug.Log(Time.deltaTime);
        transform.position = new Vector2(transform.position.x, Mathf.Lerp(transform.position.y, ball.transform.position.y, 0.05f));
	}
}
