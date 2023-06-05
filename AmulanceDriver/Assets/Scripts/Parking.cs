using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parking : MonoBehaviour
{

    public GameObject handbrake;
    public GameObject controls;
    public GameObject TimeLine;
    public GameObject GameOver;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "parking")
        {
            handbrake.SetActive(true);
        }
        if (other.gameObject.tag == "obstacle")
        {
            gameOver();
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "parking")
        {
            handbrake.SetActive(false);
        }
        if (other.gameObject.tag == "obstacle")
        {
            gameOver();
        }


    }
    public void Win()
    {
        handbrake.SetActive(false);
        controls.SetActive(false);
        TimeLine.SetActive(true);
    }
    //game over

    public void gameOver()
    {
       // Time.timeScale = 0f;
        GameOver.SetActive(true);
        controls.SetActive(false);
    }

}
