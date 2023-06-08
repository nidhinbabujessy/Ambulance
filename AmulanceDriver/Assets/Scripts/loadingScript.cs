using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScript : MonoBehaviour
{
    public Slider progressSilder;
    public GameObject loaderui;
    public void loadScene(int index)
    {
        StartCoroutine(Loadscene_coroutine(index));
    }
    public IEnumerator Loadscene_coroutine(int index)
    {
        progressSilder.value = 0;
        loaderui.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSilder.value = progress;
            if(progress>=0.9f)
            {
                progressSilder.value = 1;
                asyncOperation.allowSceneActivation = true;

            }
            yield return null;
        }
    }
}
