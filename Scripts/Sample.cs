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
        Debug.Log("Awake : Sample 오브젝트 ");

        spriteRenderer = GetComponent<SpriteRenderer>();
        
        num = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start : Sample 오브젝트 ");
        num = 5;
        print(num);
    }


    private void OnEnable()
    {
        Debug.Log("OnEnable : Sample 오브젝트 ");
        spriteRenderer.color = Color.blue;
        print(num);
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable : Sample 오브젝트 ");
        spriteRenderer.color = Color.white;
        num = 10;
        print(num);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update : Sample 오브젝트 ");
        print(num);
    }

    private void OnDestroy()
    {
        
    }
}
