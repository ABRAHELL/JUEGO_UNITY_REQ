using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour                         // Historia de usuario HU10
{                                                               // Tener checkpoint
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerRespawn>().ReachedCheckPoint(transform.position.x,transform.position.y);
            GetComponent<Animator>().enabled = true;
        }
    }
 
}
