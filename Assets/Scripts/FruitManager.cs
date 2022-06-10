using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour                   // Historia de usuario HU14 - HU08 - HU06
{                                                           // (Mostrar aviso al pasar de nivel)-(ver frutas restantes)
    public Text levelCleared;                               // (pasar al suiguiente nivel)

    public Text totalFruits;
    public Text collectedFruits;
    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;

    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        collectedFruits.text = transform.childCount.ToString();
    }
    
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No more fruits");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene",1);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
