using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class pickuptime : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject steeringPannel;
    public GameObject score;
    public GameObject timer;
    public GameObject handbrake;
    float currentTime = 0f;
    public float startingTime = 30f;
    public int index;

    [SerializeField] TMP_Text countdown;

     void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (currentTime >= 0)
        {

            currentTime -= 1 * Time.deltaTime;
            countdown.text = currentTime.ToString("0");

        }

        countdown.color = Color.white;
        if(currentTime<5)
        {
            countdown.color = Color.red;
        }
        if(currentTime<=0)
        {
            handbrake.SetActive(false);
            gameOver.SetActive(true);
            steeringPannel.SetActive(false);
            timer.SetActive(false);
            score.SetActive(false);
        }
    }
}
