using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public sound[] sfxSound;
    public sound[] musicSounds;

    public AudioSource sfsSource;
    public AudioSource musicSource;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        PLayMusic("theme");
    }
    public void PLayMusic(string name)
    {
        sound s = Array.Find(sfxSound, x => x.Name == name);
        if (s == null)
        {
            Debug.Log("sound not found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();

        }
    }
    public void PLaySfs(string name)
    {
        sound s = Array.Find(sfxSound, x => x.Name == name);
        if (s == null)
        {
            Debug.Log("sound not found");
        }
        else
        {
            musicSource.PlayOneShot(s.clip);

        }
    }

}
