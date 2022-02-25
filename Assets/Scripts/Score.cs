using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

    public void ToScore()
    {
        score++;
        GetComponent<GUIText>().text = score.ToString();
    }
}
