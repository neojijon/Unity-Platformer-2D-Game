using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionbox : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.name == "Square")
        //{
        //    Destroy(collision.gameObject,3.0f);
        //}
        //spriteRenderer =  GetComponent<SpriteRenderer>();
       // spriteRenderer.color = Color.red;

        Debug.Log("OnCollisionEnter2D");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay2D");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D");
       // spriteRenderer.color = Color.white;
    }
}
