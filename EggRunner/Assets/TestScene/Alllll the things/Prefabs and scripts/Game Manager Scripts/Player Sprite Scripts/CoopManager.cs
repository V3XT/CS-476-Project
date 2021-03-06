﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopManager : MonoBehaviour
{
    public AudioSource win;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Coop") // trigger win screen and disable movement and make invincible
        {
            if(PlayerSettings.playSoundEffects){
                win.Play();
            }
            GetComponent<HealthManager>().PermanentInvincibility();
            GetComponent<CharacterMovement>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(0).GetComponent<CameraMovement>().enabled = false;

            // trigger the win screen
            transform.GetChild(0).GetComponent<HUD>().WinGameScreen();
        }
    }
}
