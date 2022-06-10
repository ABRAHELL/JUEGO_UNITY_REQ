using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorSkins : MonoBehaviour            // Historia de usuario HU02-HU13
{                                                       // (Ver niveles disponibles)- (Tener skins)
    public GameObject skinsPanel;   // Puerta de skins
    private bool inDoor = false;    // Variable para detectar si se encuentra en contacto con una puerta 
    public GameObject player;      

    private void OnTriggerEnter2D(Collider2D collision)    // Detectar cuando este collider entre en 
    {                                                      // contacto con otro collider
        if (collision.CompareTag("Player"))                // Si colisiona con el colider del jugador
        {
            skinsPanel.gameObject.SetActive(true);         // Se activa el panel que muestras las skins 
            inDoor = true;                                 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)     // Si se deja de estar en contacto
    {
        skinsPanel.gameObject.SetActive(false);            // Se deja de mostrar el panel
        inDoor = false;
    }

    public void SetPlayerPinkMan()                           // Asignar skin PinkMan
    {
        PlayerPrefs.SetString("PlayerSelected", "PinkMan");  
        ResetPlayerSkin();
    }

    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected", "VirtualGuy");
        ResetPlayerSkin();

    }
        
    public void SetPlayerMaskDude()
    {
        PlayerPrefs.SetString("PlayerSelected", "MaskDude");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()                                          // Reasignar skin
    {
        skinsPanel.gameObject.SetActive(false);                     // Apagar panel de skins una vez seleccionada una
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();   // Se cambia la skin a tiempo real en el menú
    }
}
