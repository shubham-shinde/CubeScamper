using UnityEngine;
using UnityEngine.UI;

public class MaxScoreShow : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Max Score : " + score.ToString("0");
    }
}
