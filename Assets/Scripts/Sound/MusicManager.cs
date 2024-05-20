using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource soundSource;
    public int currentPlayer;
    [SerializeField]
    public AudioComponent AudioSettings;
    void Start()
    {
        currentPlayer = 0;
        musicSource.clip = AudioSettings.AudioClips[currentPlayer];
        musicSource.loop = true;
        musicSource.Play();
        musicSource.volume = AudioSettings.MusicIsOn ? 0.5f : 0f;
        soundSource.volume = AudioSettings.SoundIsOn ? 1f : 0f;
    }

    public void ToggleMusicState()
    {
        AudioSettings.MusicIsOn = !AudioSettings.MusicIsOn;
        musicSource.volume = AudioSettings.MusicIsOn ? 0.5f : 0f;
    }

    public void ToggleSoundState()
    {
        AudioSettings.SoundIsOn = !AudioSettings.SoundIsOn;
        soundSource.volume = AudioSettings.SoundIsOn ? 1f : 0f;
    }

    public void PlayErrorSound()
    {
        soundSource.PlayOneShot(AudioSettings.AudioClips[1]);
    }

    public void PlayScoreSound()
    {
        soundSource.PlayOneShot(AudioSettings.AudioClips[2]);
    }
}
