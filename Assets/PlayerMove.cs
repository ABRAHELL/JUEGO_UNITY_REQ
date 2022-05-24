using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    [Header("Variables")]

    public float runSpeed = 2;      // movimiento eje x
    public bool betterJump = false;
    public float jumpSpeed = 3;     //salto
    public float fallMultiplier = 0.5f; 
    public float lowJumpMultiplier = 1f;
    Rigidbody2D rb2D;
  
   


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

  
    void FixedUpdate()
    {
      if (Input.GetKey("d") || Input.GetKey("right"))    //si se oprime d o derecha
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);  // se mueve positivamente en el eje x
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))  // si se prome a o izquierda
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);  // se mueve negativamente en el eje x
        }
        else
        {
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
        }
        if (Input.GetKey("up") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
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
