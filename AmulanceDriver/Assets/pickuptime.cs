using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class pickuptime : MonoBehaviour
{
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
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");

        countdown.color = Color.white;
        if(currentTime<5)
        {
            countdown.color = Color.red;
        }
        if(currentTime<=0)
        {
            SceneManager.LoadScene(index);
        }
    }
}
