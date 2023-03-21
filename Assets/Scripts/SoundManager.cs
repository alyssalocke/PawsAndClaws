using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource buttonSoundPlayer;
    public AudioSource cutSoundPlayer;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PlayButtonClick()
    {
        buttonSoundPlayer.Play();
    }
    public void PlayCutClick()
    {
        cutSoundPlayer.Play();
    }
}