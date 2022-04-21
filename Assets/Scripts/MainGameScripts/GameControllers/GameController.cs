using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;

public class GameController : MonoBehaviour
{
    public FallingObject.FallingObject ObjectToSpawn;
    public FallingObjectSpawner fallingObjectSpawner;
    public PauseMenu menu;
    public Score score;
    public MistakeCounter mistakeCounter;
    public Camera mainCamera;
    public GameMode gameMode;


    void Start()
    {
        Time.timeScale = 1f;
    }
}
