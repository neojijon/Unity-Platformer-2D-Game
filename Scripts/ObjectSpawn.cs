using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    //public GameObject gsmeobj1;
    //public GameObject gsmeobj2;
    //public GameObject gsmeobj3;

    public GameObject[] gsmeobjs;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = new Vector3(1, 1, 1);
        //Instantiate(gsmeobj1, new Vector3(1, 1, 10), Quaternion.identity);
        //Instantiate(gsmeobj2, new Vector3(3, 3, 20), Quaternion.Euler(0,0,90));
        //Instantiate(gsmeobj3, new Vector3(2, 2, 30), Quaternion.identity);

        for(int i = 0; i < gsmeobjs.Length; i++)
        {
            if (i == 1)
                continue;

            for (int j = 0; j < gsmeobjs.Length; j++)
                Instantiate(gsmeobjs[0], new Vector3(i+1, j+1, 0), Quaternion.identity);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
