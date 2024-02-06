using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 싱글톤으로 사용할 오브젝트를 편하게 만들기 위한 클래스
/// 이 클래스를 상속받으면 자연스럽게 싱글톤 오브젝트가 된다.
/// </summary>
public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance;			// 인스턴스.

	// static 생성자.
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {                
				// 오브젝트를 찾고 없으면 새로 만든다.
                _instance = FindObjectOfType(typeof(T)) as T;

                if (_instance == null)
                    _instance = new GameObject(typeof(T).Name, typeof(T)).GetComponent<T>();

                SingletonList.AddSingleton<T>();
            }

            return _instance;
        }
    }

    virtual public void OnDestroy()
    {
        SingletonList.DeleteSingleton<T>();
    }
}