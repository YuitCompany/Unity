using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource bgMusic, jumpMusic, dieMusic;

    void Start()
    {
        PlayBGMusic();
    }

    void PlayBGMusic()
    {
        bgMusic.Play();
    }

    public void PlayFlapMusic()
    {
        jumpMusic.Play();
    }

    public void PlayFallMusic()
    {
        dieMusic.Play();
    }
}
