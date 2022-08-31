using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
   // public AudioSource[] musicPlayers;
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMusicPlayer(int newPlayer)
    {
        /*
        musicPlayers[currentPlayer].Stop();
        currentPlayer = newPlayer;
        musicPlayers[currentPlayer].Play();
        */
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
        Debug.Log("AAAAAAAAAAAAAAAAAAASFGas");
    }

    public void PlayScoreSound()
    {
        soundSource.PlayOneShot(AudioSettings.AudioClips[2]);
    }
}
