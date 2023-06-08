using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioLongPress : MonoBehaviour
{
 
 public AudioSource brakeAudio, buttonclick;
    /*
       private AudioSource audiosrc;
   private void Start()
   {
       audiosrc = GetComponent<AudioSource>();
   }
   public void PlayBeep()
   {
       audiosrc.Play();
   }
   public void DontPlay()
   {
       audiosrc.Stop();
   }*/

    public void brake()
    {
        brakeAudio.Play();
    }
    public void buttonClick()
    {

        buttonclick.Play();
    }
}
