using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// �̱������� ����� ������Ʈ�� ���ϰ� ����� ���� Ŭ����
/// �� Ŭ������ ��ӹ����� �ڿ������� �̱��� ������Ʈ�� �ȴ�.
/// </summary>
public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance;           // �ν��Ͻ�.

    // static ������.
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // ������Ʈ�� ã�� ������ ���� �����.
                _instance = FindObjectOfType(typeof(T)) as T;

                if (_instance == null)
                {
                    // _instance = new GameObject(typeof(T).Name, typeof(T)).GetComponent<T>();
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                }
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