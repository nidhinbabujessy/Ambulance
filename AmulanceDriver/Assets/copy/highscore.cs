using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text highScoreText;

    public void scoreUpdate()
    {
        int number = PlayerPrefs.GetInt("HighScore", 0) + 100;
        PlayerPrefs.SetInt("HighScore", number);
        highScoreText.text = number.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
