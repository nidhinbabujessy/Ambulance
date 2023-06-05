using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class startingcount : MonoBehaviour
{
    float counter;
    public TextMeshProUGUI coundertext;

    public GameObject timeline;
    public GameObject controlPanel;
    public GameObject counterScreen;
    public AudioSource carIdel;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        counter += 1 * Time.deltaTime;
        coundertext.text = counter.ToString("0");


        if (counter >= 3)
        {
            timeline.SetActive(false);
            controlPanel.SetActive(true);
            counterScreen.SetActive(false);
            //  AudioManager.Instance.PLaySfs("car idl");
          //  carIdel.Play();
            
        }
    }


}
