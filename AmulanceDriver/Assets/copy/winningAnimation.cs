using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class winningAnimation : MonoBehaviour
{
   // public highscore HighSCore;
   //public TMP_Text score;
   
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
        LeanTween.scale(homebutton, new Vector3(4.050534f, 10.474f, 5.32f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(nextbutton, new Vector3(3.724629f, 10.474f, 5.32f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);

    }

    void star()
    {
        LeanTween.scale(star1, new Vector3(2.7f, 1.9f, 2.2f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star2, new Vector3(4f, 2.8f, 3.3f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star3, new Vector3(2.7f, 1.9f, 2.2f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
    }

   // void levelscore()
   // {
   //     int n = 100;
  //      score.text = n.ToString();
   // }

}