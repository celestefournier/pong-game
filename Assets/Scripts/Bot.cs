using System.Collections;
using UnityEngine;

public class Bot : Player
{
    Vector2 ball_pos;

    void Start()
    {
        ball = GameObject.Find("Ball");
        sizePlayer_y = GetComponent<BoxCollider2D>().size.y;
        velocidade = 7.5f;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Lerp(transform.position.y, ball.transform.position.y, 0.05f));
    }
}
