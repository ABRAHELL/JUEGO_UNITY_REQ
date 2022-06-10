using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour                                   //Historia de usuario HU07 - HU05
{                                                                           // (tener enemigos) - (tener obstáculos)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Ouch");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
        }
        
    }

}
