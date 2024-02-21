using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finsish : MonoBehaviour
{
    [SerializeField] private string nextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.Equals("Player"))
        {
            DontDestroyOnLoad(collision.gameObject);

            //Playercontroller playerControl = collision.gameObject.GetComponent<PlayerController>();
            Debug.Log("Finish !!!!!");

            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(currentSceneIndex + 1);

            //SceneManager.LoadScene(nextSceneName);
        }        
    }
}
