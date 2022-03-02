using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSoundControl : MonoBehaviour
{
    AudioClip clip;
    AudioSource[] source;
    [SerializeField] private int audioClipToPlay;
    [SerializeField] private float maxPauseBetwenSounds = 6;
    [SerializeField] private float minPauseBetwenSounds = 2;
    [SerializeField]private float actualPauseBetwenSounds;
    private void Start()
    {
        clip = GetComponent<AudioClip>();
        source = GetComponents<AudioSource>();
        TimeRandomizer();
    }
    private void Update()
    {
        PlayingSound();
    }
    private void AudioClipRandomaizer()
    {
        audioClipToPlay = Random.Range(1,source.Length);
    }
    private void Timer()
    {
        actualPauseBetwenSounds -= Time.deltaTime;
    }
    private void TimeRandomizer()
    {
        actualPauseBetwenSounds = Random.Range(minPauseBetwenSounds, maxPauseBetwenSounds);
    }

    private void PlayingSound()
    {
        Timer();
        if (actualPauseBetwenSounds <= 0)
        {
            AudioClipRandomaizer();
            
            {
                //source[audioClipToPlay].clip.PlayOneShot();
                TimeRandomizer();
            }
        }
    }
}
