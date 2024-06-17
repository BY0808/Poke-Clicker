using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEffectPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundEffectClips;
    private AudioSource audioSource;
    [SerializeField] private ClickInput _clickInput;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _clickInput.OnClickEvent += PlayRandomMusicEffect;
    }

    private void PlayRandomMusicEffect(int click)
    {
        int randomIndex = Random.Range(0, soundEffectClips.Length);
        audioSource.clip = soundEffectClips[randomIndex];
        audioSource.Play();
    }
}
