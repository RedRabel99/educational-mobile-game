using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource[] musicPlayers;
    public int currentPlayer;
    void Start()
    {
        currentPlayer = 0;
        musicPlayers[currentPlayer].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMusicPlayer(int newPlayer)
    {
        musicPlayers[currentPlayer].Stop();
        currentPlayer = newPlayer;
        musicPlayers[currentPlayer].Play();
    }
}
