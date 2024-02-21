using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene ingamescene = SceneManager.GetSceneByName("InGame");
        if (ingamescene.IsValid())
        {           
            GameObject[] objs = ingamescene.GetRootGameObjects();
            foreach (GameObject playobj in objs)
            {
                if (playobj.name == "Player")
                {   
                    PlayerController player = playobj.GetComponent<PlayerController>();

                    //if (player.bStartpointChaeck)
                    {
                        playobj.transform.position = transform.position;
                        //player.bStartpointChaeck = false;
                    }
                }
            }
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
