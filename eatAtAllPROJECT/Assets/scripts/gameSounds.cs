using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class gameSounds : MonoBehaviour
{

    [SerializeField] AudioSource winSound;
    [SerializeField] AudioSource deathSound;
    [SerializeField] AudioSource portalSound;


    public void playDeathSound()
    {
        deathSound.Play();
    }


    public void playWinSound()
    {
        winSound.Play();
    }

    public void playPortalSound()
    {
        portalSound.Play();
    }



}
