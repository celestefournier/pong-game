using UnityEngine;

public class Ball : MonoBehaviour {

    public float velocidade;
    public Vector2 move;
    GameObject score1, score2;

    void Start () {
        score1 = GameObject.Find("Score1");
        score2 = GameObject.Find("Score2");

        move.x = 0.5f;
        move.y = 0.5f;
        move.Normalize();
    }
	
	void FixedUpdate () {
        Movimentar();
    }

    void Movimentar()
    {
        transform.Translate(new Vector2(move.x, move.y) * velocidade * Time.deltaTime);
    }

    void MudarDirecao(float x, float y)
    {
        move.x *= -x;
        move.y *= -y;
        move.Normalize();   //Mantém a magnitude (ângulo circular) do vetor como 1.
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")       //Se bater em qualquer parede, chama a função de espelhar em y.
        {
            move.y *= -1;
            move.Normalize();
        }
        if (col.gameObject.tag == "Player")     //Se bater no jogador, chama a função de espelhar em x.
        {
            move.x *= -1;
            move.Normalize();
        }
        if (col.gameObject.name == "Goal_left") //Se bater no "gol" da esquerda, chamar a função de ToScore = pontuar
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
