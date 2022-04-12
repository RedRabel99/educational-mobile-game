using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
   // public AudioSource[] musicPlayers;
    AudioSource audioSource;
    public int currentPlayer;
    [SerializeField]
    public AudioComponent AudioSettings;
    void Start()
    {
        currentPlayer = 0;
       //musicPlayers[currentPlayer].Play();
        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource);
        Debug.Log(AudioSettings);
        Debug.Log(AudioSettings.AudioClips);
        audioSource.clip = AudioSettings.AudioClips[currentPlayer];
        audioSource.loop = true;
        audioSource.Play();
        audioSource.volume = AudioSettings.MusicIsOn ? 1f : 0f;
        Debug.Log("DUPA" + AudioSettings.MusicIsOn);
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
        audioSource.volume = AudioSettings.MusicIsOn ? 1f : 0f;
    }

    public void ToggleSoundState()
    {
        AudioSettings.SoundIsOn = !AudioSettings.SoundIsOn;
    }
}
