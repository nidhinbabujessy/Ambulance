using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpage : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("0.1 menu");
    }
    public void firstlevel()
    {
        SceneManager.LoadScene("level1");
    }
    public void secondlevel()
    {
        SceneManager.LoadScene("level2");
    }
   
}
