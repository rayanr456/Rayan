using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;
    private bool isPlaying = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (isPlaying)
            {
                StopSoundEffect();
                isPlaying = false;
                //Debug.Log("Audio is not playing!");
            }
        }

        else if(Input.GetMouseButtonDown(0))
        {
            PlaySoundEffect();
            isPlaying = true;
            //Debug.Log("Audio is playing!");
        }
    }

    public void PlaySoundEffect()
    {
        audioSource.clip = soundEffect;
        audioSource.Play();
    }

    public void StopSoundEffect()
    {
        audioSource.Stop();
    }


}
