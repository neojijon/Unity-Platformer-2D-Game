using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement playerMove;
    Animator animator;

    void Start()
    {
        playerMove = GetComponent<Movement>();
        animator = GetComponent<Animator>();
    }
        
    void Update()
    {
        Moveing();
        Jump();
        Slide();
        Death();
        Attack();
    }

    void Moveing()
    {
        float x = Input.GetAxis("Horizontal");
        playerMove.MoveX(x);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            playerMove.JumpY();

        if (Input.GetKey(KeyCode.Space))
        {
            playerMove.bJumping = true;
        }            
        else if (Input.GetKeyUp(KeyCode.Space))
            playerMove.bJumping = false;
    }

    void Slide()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            animator.Play("Slide");
            //playerMove.MoveX(1);
        }
    }

    void Death()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            animator.Play("Death");
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            animator.Play("Attack");
        }
    }
}
