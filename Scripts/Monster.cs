using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    SpriteRenderer sprite;
    Rigidbody2D rigid;
    Animator animator;

    public LayerMask layermask;

    public float speed;
    public GameObject targetPlay;
    public int nFront = -1;// 0, 1  * -1 
    public float fThinkTime;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        Invoke("AIThink", 3f);
        //InvokeRepeating("AIThink", 3f, 3f);
    }

    void FixedUpdate()
    {
        // 정면 벽체크
        RaycastHit2D raycastHit = Physics2D.Raycast(this.transform.position, new Vector2(nFront,0), 1f, layermask);

        //Color rayColor;
        if (raycastHit.collider != null)
        {
            Turn();
            Debug.Log(raycastHit.collider);
        }

        Debug.DrawRay(this.transform.position, new Vector2(nFront, 0), Color.red);

        //바닥체크
        raycastHit = Physics2D.Raycast(new Vector2(this.transform.position.x + nFront, this.transform.position.y) , Vector2.down, 3f, layermask);
        
        if (raycastHit.collider == null)
        {
            Turn();
            Debug.Log(raycastHit.collider);
        }

        Debug.DrawRay(new Vector2(this.transform.position.x + nFront, this.transform.position.y), Vector2.down*3f, Color.blue);

        rigid.velocity = new Vector2(nFront * speed, rigid.velocity.y);
    }

    public void AIThink()
    {
        nFront = Random.Range(-1, 2);

        sprite.flipX = nFront > 0 ? true : false;
        fThinkTime = Random.Range(3f, 5f);

        Debug.Log(nFront);
        animator.SetInteger("Run", nFront);

        Invoke("AIThink", fThinkTime);
    }

    public void Turn()
    {
        nFront *= -1;
        sprite.flipX = nFront > 0 ? true : false;
        animator.SetInteger("Run", nFront);
    }
}
