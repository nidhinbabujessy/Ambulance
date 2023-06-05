using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highscore : MonoBehaviour
{
    int number;


    public TMP_Text highscor;
    // Start is called before the first frame update
    void Start()
    {
        highscor.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void scoreUpdate()
    {
        number = number + 100;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.GetInt("HighScore", number);
            highscor.text = number.ToString();
        }
    }
}
