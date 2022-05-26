using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public enum Player {PinkMan, VirtualGuy, MaskDude};
    public Player playerSelected;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;



    void Start()
    {
        switch (playerSelected)
        {
            case Player.PinkMan:
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case Player.MaskDude:
                spriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playersController[2];
                break;
        
        }
        
    }
}
