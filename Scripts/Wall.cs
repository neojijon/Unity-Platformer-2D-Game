using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Monster")
        {
            Debug.Log("OnCollisionEnter2D");
           Monster mon = collision.gameObject.GetComponent<Monster>();
            mon.Turn();
        }
    }
}
