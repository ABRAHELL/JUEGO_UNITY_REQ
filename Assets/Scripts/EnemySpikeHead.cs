using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpikeHead : MonoBehaviour                            //Historia de usuario HU07
{                                                                      // (tener enemigos)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("oughhhh");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
        }
        
    }

}
