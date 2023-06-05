using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestart : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("level1");
    }

    public void home()
    {
        SceneManager.LoadScene("firstpage");
    }
}
