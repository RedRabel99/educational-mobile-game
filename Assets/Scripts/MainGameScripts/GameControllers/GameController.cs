using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;

public class GameController : MonoBehaviour
{
    public FallingObject.FallingObject ObjectToSpawn;
    public FallingObjectSpawner fallingObjectSpawner;
    public PauseMenu pauseMenu;
    public Score score;
    public MistakeCounter mistakeCounter;
    public Camera mainCamera;
    public GameMode gameMode;
    public Countdown countdown;
    public PauseController pauseController;
    public BuffSystemInGame buffSystem;
    public BestScoreController bestScoreController;
    public CoinAdder coinAdder;
    void Start()
    {
        Time.timeScale = 1f; //nvm
        StartCoroutine(countdown.CountdownToStart(3));  
    }
}
