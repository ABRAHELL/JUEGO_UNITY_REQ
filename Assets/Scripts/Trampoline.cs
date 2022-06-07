using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public Animator animator;
    public float jumpForce = 2f;

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.transform.CompareTag("Player"))      // al momento de colisionar con el jugador
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up*jumpForce);   // se cambia la física del personaje principal, la veriable de velocidad, con un vector en el eje y.
            animator.Play("JumpTrampoline");
        }

    }
}
