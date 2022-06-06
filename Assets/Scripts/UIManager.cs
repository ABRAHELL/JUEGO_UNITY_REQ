using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;

    public void OptionsPanel()       
    {
        Time.timeScale = 0;   //Parar el tiempo en unity, todo se deja de mover (las físicas)
        optionsPanel.SetActive(true);       // activamos el menú de opciones    
    }

    public void Return()
    {
        Time.timeScale = 1;   // sigue el juego y las físicas de éste
        optionsPanel.SetActive(false);  //  se desactiva el panel de opciones, deja de ser visible
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");  // dirigirse a la escena del manú principal
    }

    public void QuitGame()
    {
        Application.Quit();  // método propio de Unity, sólo funcional al utilizarlo en apk/build/ejecutable
    }


}
