using UnityEngine;
using System.Collections;

public class DontDestroy : MonoSingleton<DontDestroy>
{
	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
	}

    public override void OnDestroy()
    {
        SingletonList.Clear();
    }
}
