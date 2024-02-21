using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    Movement2D playerMove;
    Animator animator;
    string message = "¸Þ¼¼Áö";

    public bool bStartpointChaeck;

    void Start()
    {
        playerMove = GetComponent<Movement2D>();
        animator = GetComponent<Animator>();
        GameObject.Find("Player").SetActive(true);
    }


    private void OnEnable()
    {
        if(bStartpointChaeck)
        {
            //transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
            //transform.position = GameObject.Find("startPoint").transform.position;
            bStartpointChaeck = false;

            //Variables variables = GameObject.Find("VisualScripting SceneVariables").GetComponent<SceneVariables>();

            //string mapname = variables.GetVariable("currentBattleMap")


            

        }
    }
    private void OnDisable()
    {

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
