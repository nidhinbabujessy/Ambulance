using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioLongPress : MonoBehaviour
{
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
    }
}
