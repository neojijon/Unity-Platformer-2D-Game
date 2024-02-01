using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{   
    Animator animator;
    PlayerController playerController;
    Rigidbody2D rigid2d;
    SpriteRenderer spriteRenderer;
    [SerializeField] private float fSpeed = 1.0f;

    [SerializeField] private float fJumpForce = 10.0f;

    bool bRuning = false; //
    public bool bJumping = false;


    void Awake()
    {       
        playerController = GetComponent<PlayerController>();
        rigid2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void MoveX(float fvalue)
    {
        bool bRunState = animator.GetBool("Runing");

        if (fvalue == 0.0f)
        {
            animator.SetBool("Runing", false);
            bRuning = false;
            return;
        }                        

        if(bRunState == false)
        {
            animator.SetBool("Runing", true);
            bRuning = true;
        }

        spriteRenderer.flipX = (fvalue > 0) ? false : true ;


        rigid2d.velocity = new Vector2(fvalue * fSpeed, rigid2d.velocity.y);
    }

    public void JumpY() {        
        rigid2d.velocity = Vector2.up * fJumpForce;

    }

    private void FixedUpdate()
    {
        if (bJumping)
        {
            rigid2d.gravityScale = 1;

            bool bRunState = animator.GetBool("Jumping");
            if(bRunState == false)
            {
                animator.SetBool("Jumping", true);
            }
        }
        else            
        {
            rigid2d.gravityScale = 2.0f;
            
            if (rigid2d.velocity.y < 0.1f)
            {
                animator.SetBool("Jumping", false);
            }
        }
    }

}
