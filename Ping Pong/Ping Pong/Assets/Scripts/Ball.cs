using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public float velocidade;
    float movex, movey;
    GameObject score1, score2;

    void Start () {
        movex = -0.2f;
        movey = -1;

        score1 = GameObject.Find("Score1");
        score2 = GameObject.Find("Score2");
    }
	
	void Update () {
        transform.position += new Vector3(movex, movey, 0) * velocidade * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            movey *= -1;
        }
        if (col.gameObject.tag == "Player")
        {
            movex *= -1;
        }
        if (col.gameObject.name == "Goal_left")
        {
            score2.GetComponent<Score>().ToScore();
            transform.position = new Vector3(0, 0, 0);
        }
        if (col.gameObject.name == "Goal_right")
        {
            score1.GetComponent<Score>().ToScore();
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
