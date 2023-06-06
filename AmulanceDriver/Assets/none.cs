using UnityEngine;
using TMPro;

public class none : MonoBehaviour
{
    private int score;
    private int highScore;

    public TMP_Text highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScores", 0);
        highScoreText.text = highScore.ToString();
    }

    public void IncrementScore()
    {
        score += 100;
    }

    public void SaveHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScores", highScore);
            highScoreText.text = highScore.ToString();
        }
    }
}
