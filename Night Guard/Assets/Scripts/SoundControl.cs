using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField] public AudioSource sound;
    [SerializeField] private float minPauseBetweenSounds = 5;
    [SerializeField] private float maxPauseBetweenSounds = 10;
    [SerializeField] private float actualPauseBetweenSounds;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlaySound();
    }
    private void TimerRandomizer()
    {
        actualPauseBetweenSounds = Random.Range(minPauseBetweenSounds, maxPauseBetweenSounds);
    }
    private void Timer()
    {
       
            actualPauseBetweenSounds -= Time.deltaTime;
   
    }
    private void PlaySound()
    {
        Timer();
        if (actualPauseBetweenSounds <= 0)
        {
            sound.Play();
            TimerRandomizer();
        }
    }
}
