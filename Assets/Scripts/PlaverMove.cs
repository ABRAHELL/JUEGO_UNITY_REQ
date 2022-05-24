using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaverMove : MonoBehaviour
{
    [Header("Variables")]

    public float runSpeed = 2;      // movimiento eje x
    public bool betterJump = false;
    public float jumpSpeed = 3;     //salto
    public float fallMultiplier = 0.5f; 
    public float lowJumpMultiplier = 1f;
    Rigidbody2D rb2D;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
                                                    //ANIMACIONES PERSONAJE
                                                                        


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

  
    void FixedUpdate()
    {
      if (Input.GetKey("d") || Input.GetKey("right"))    //si se oprime d o derecha
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);  // se mueve positivamente en el eje x
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))  // si se prome a o izquierda
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);  // se mueve negativamente en el eje x
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }

        else
        {
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
            animator.SetBool("Run", false);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump",true);
            animator.SetBool("Run",false);
        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump",false);
        }
        if (betterJump)
        {
            if (rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if (rb2D.velocity.y>0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }  
    }
}
