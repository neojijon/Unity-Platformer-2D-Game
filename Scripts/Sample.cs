using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    Color color;
    SpriteRenderer spriteRenderer;
    int num;

    private void Awake()
    {
        Debug.Log("Awake : Sample ������Ʈ ");

        spriteRenderer = GetComponent<SpriteRenderer>();
        
        num = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start : Sample ������Ʈ ");
        num = 5;
        print(num);
    }


    private void OnEnable()
    {
        Debug.Log("OnEnable : Sample ������Ʈ ");
        spriteRenderer.color = Color.blue;
        print(num);
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable : Sample ������Ʈ ");
        spriteRenderer.color = Color.white;
        num = 10;
        print(num);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update : Sample ������Ʈ ");
        print(num);
    }

    private void OnDestroy()
    {
        
    }
}
