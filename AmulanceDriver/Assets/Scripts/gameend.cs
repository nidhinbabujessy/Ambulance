using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameend : MonoBehaviour
{
    public GameObject win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            win.SetActive(true);
           // Time.timeScale = 0f;
        }
    }
}
