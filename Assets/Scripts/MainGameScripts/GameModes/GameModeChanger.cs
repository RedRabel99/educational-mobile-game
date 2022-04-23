using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameModeChanger : MonoBehaviour
{
    [SerializeField] TMP_Text currentGameModeText;
    [SerializeField] GameMode gameMode;
    [SerializeField] GameController gameController;
    float lastTimeChanged;
    float minimumTimeBetweeenChange = 13f;
    bool changeGameMode;

    void Start()
    {
        currentGameModeText.text = gameMode.GetGameModeName();
        lastTimeChanged = Time.time;
        changeGameMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLastTimeChange();
        ChangeGameModeIfEnoughTimePassed();
    }

    void UpdateLastTimeChange()
    {
        if (gameController.pauseMenu.isPaused) return;
        if (Time.time - lastTimeChanged <= minimumTimeBetweeenChange) return;
       // Debug.Log($"time: {Time.time - lastTimeChanged} RANDOM: ");
        var generator = new System.Random();
        if (generator.Next(100) <= Time.time - lastTimeChanged)
        {
        //    Debug.Log($"TRUEEEEEEEEE");
            changeGameMode = true;
        }

    }

    void ChangeGameModeIfEnoughTimePassed()
    {
        if (!changeGameMode) return;
        gameController.fallingObjectSpawner.CanSpawn = false;
        GameObject[] fallingObjects = GameObject.FindGameObjectsWithTag("FallingObject");

        if (fallingObjects.Length != 0) return;

        lastTimeChanged = Time.time;
        
        changeGameMode = false;
        ChangeMode();
        gameController.fallingObjectSpawner.CanSpawn = true;
    }

    void ChangeMode()
    {
        gameMode.SetGameMode();
        currentGameModeText.text = gameMode.GetGameModeName();
    }
}
