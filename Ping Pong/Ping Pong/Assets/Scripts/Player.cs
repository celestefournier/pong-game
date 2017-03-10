using UnityEngine;

public class Player : MonoBehaviour {

    public bool jogavel;
    protected float velocidade;
    protected float sizePlayer_y;
    protected GameObject ball;

    void Start () {
        ball = GameObject.Find("Ball");
        sizePlayer_y = GetComponent<BoxCollider2D>().size.y;
        velocidade = 7.5f;
	}

	void Update () {
        Andar();
    }

    void Andar()
    {
        if (jogavel)
        {
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                transform.Translate(Vector3.up * velocidade * Time.deltaTime);  // Anda pra cima
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                transform.Translate(Vector3.down * velocidade * Time.deltaTime); // Anda pra baixo
            }
            // Limitando a distância que o jogador pode percorrer
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.85f, 3.85f), 0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        foreach (ContactPoint2D ballHit in coll.contacts)
        {
            Vector2 hitPoint = ballHit.point;
            float pos_y = hitPoint.y - (transform.position.y);                  //Diferença de distância y entre o mundo 
            ball.GetComponent<Ball>().move.y = pos_y / (sizePlayer_y / 2);
            ball.GetComponent<Ball>().move.x *= 1;
            ball.GetComponent<Ball>().move.Normalize();
        }
    }
}
