using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoSingleton<DontDestroy>
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
