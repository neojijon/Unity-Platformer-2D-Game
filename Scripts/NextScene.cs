using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] private string nextScene;

    public void OnClickNextScne()
    {
        SceneManager.LoadScene(nextScene);
        GameObject player = GameObject.Find("Player");
        //player.SetActive(true);
        player.GetComponent<PlayerController>().bStartpointChaeck = true;
    }

    public void RetryScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
