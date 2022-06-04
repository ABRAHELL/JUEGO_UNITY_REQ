using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

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
