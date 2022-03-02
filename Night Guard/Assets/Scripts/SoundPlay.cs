using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    [SerializeField] public AudioSource sound;

    public void PlaySound()
    {
        if (!sound.isPlaying)
        {
            sound.Play();
        }
    }
    public void StopPlayingSound()
    {
        sound.Stop();
    }
}
