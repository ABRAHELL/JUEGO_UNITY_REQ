using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;                 // Al coger la manzana
            gameObject.transform.GetChild(0).gameObject.SetActive(true);    // Se desactiva el sprite de la fruta
            
            //FindObjectOfType<FruitManager>().AllFruitsCollected();

            Destroy(gameObject, 0.5f);                                      // Se destruye la fruta
        }
    }
}
