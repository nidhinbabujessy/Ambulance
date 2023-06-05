using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamefail : MonoBehaviour
{
    public GameObject GameOver;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
