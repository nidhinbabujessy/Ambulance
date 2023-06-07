using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuButtons : MonoBehaviour
{
    [SerializeField] GameObject reset;
    [SerializeField] GameObject volume;

    public void ResetEnable()
    {
        reset.SetActive(true);
    }
    public void ResetDesable()
    {
        reset.SetActive(false);
    }

    //-----------------------------------

    public void VolumeE()
    {
        volume.SetActive(true);
    }
    public void VolumeD()
    {
        volume.SetActive(false);
    }

    //----------------------------------------------

    public void quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
