using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneController : MonoBehaviour
{
    [SerializeField]
    private Image progressBar;
    [SerializeField]
    private CanvasGroup canvasGroup;

    [SerializeField]
    private string lodingScene;

    [SerializeField]
    private GameObject player;

    private void Start()
    {
        //SceneManager.sceneLoaded += OnSceneLoaded;
        //SceneManager.LoadScene("Scenes/Lobby");
        //StartCoroutine(LoadSceneProgress());
        //DontDestroyOnLoad(player);
        player.SetActive(false);

    }

    public void LoadingScene(string sceneName)
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        lodingScene = sceneName;
        StartCoroutine(LoadSceneProgress());
        //SceneManager.LoadScene(lodingScene);
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if(arg0.name == lodingScene) {
            Debug.Log(arg0.name);            
            SceneManager.sceneLoaded -= OnSceneLoaded;
            StopCoroutine(LoadSceneProgress());            
        }
        return;
    }


    private IEnumerator  LoadSceneProgress()
    {
        progressBar.fillAmount = 0;
        yield return null;

        AsyncOperation op = SceneManager.LoadSceneAsync(lodingScene);
        op.allowSceneActivation = false;

        float timer = 0.0f;
        while(!op.isDone)
        {
            yield return null;
            if(op.progress < 0.9f)
            {
                progressBar.fillAmount = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                progressBar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);
                if(progressBar.fillAmount >= 1f)
                {
                    op.allowSceneActivation = true;
                    player.SetActive(true);
                    player.GetComponent<PlayerController>().bStartpointChaeck = true;
                    yield break;
                }
            }
        }
    }
}
