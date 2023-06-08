using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class winningAnimation : MonoBehaviour
{
    //  public highscore HighSCore;
    //public TMP_Text score;
    public AudioSource starAudio;
   
    [SerializeField]
    GameObject backpannel, homebutton, nextbutton, star1, star2, star3, missionpassed;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(missionpassed, new Vector3(13f, 13f, 13f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(levelComplete);
        LeanTween.moveLocal(missionpassed, new Vector3(-1f, -100f, 13f), .7f).setDelay(.5f).setEase(LeanTweenType.easeInOutCubic);
    }

    void levelComplete()
    {
        LeanTween.moveLocal(backpannel, new Vector3(0f, -90f, 0f), .1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc).setOnComplete(star);
       
    }

    void star()
    {
        starAudio.Play();
        LeanTween.scale(star1, new Vector3(2.7f, 1.9f, 2.2f), 2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(button);
        LeanTween.scale(star2, new Vector3(4f, 2.8f, 3.3f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star3, new Vector3(2.7f, 1.9f, 2.2f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
    }
    void button()
    {
        LeanTween.moveLocal(homebutton, new Vector3(-217f, -350f, 0f), .1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.moveLocal(nextbutton, new Vector3(373f, -360f ,0f), .1f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);

    }



    // {
    //     int n = 100;
    //      score.text = n.ToString();
    // }

}
