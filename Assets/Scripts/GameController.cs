using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;

public class GameController : MonoBehaviour
{
    [SerializeField] FallingObject.FallingObject ObjectToSpawn;
    public PauseMenu menu;
    public const float LEFT_SIDE_X = -3.7f;
    public const float RIGHT_SIDE_X = 3.7f;
    public const float SPAWN_HEIGHT = 10.0f;
    public double timeBeetwinSpawns;
    public double lastSpawnTime;
    public short mistakeCounter;
    public MusicManager musicManager;

    public SpriteRenderer leftCross;
    public SpriteRenderer rightCross;
    public SpriteRenderer midCross;
    void Start()
    {
        timeBeetwinSpawns = 2.0;
        lastSpawnTime = Time.time;
        mistakeCounter = 0;
        CrossInit();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnFallingObject();
    }

    void SpawnFallingObject()
    {
        if (Time.time - lastSpawnTime > timeBeetwinSpawns)
        {
            lastSpawnTime = Time.time;
            float spawnWidth = Random.Range(LEFT_SIDE_X, RIGHT_SIDE_X);
            Vector3 spawningPosition = new Vector3(spawnWidth, SPAWN_HEIGHT, 0f);
            Instantiate(ObjectToSpawn, spawningPosition, transform.rotation);
        }
        
    }

    public void IncreaseMistakeValue()
    {
        mistakeCounter++;
        if (mistakeCounter == 1)
        {
            leftCross.color = new Color(1f, 1f, 1f, 1f);
        }
        if (mistakeCounter == 2)
        {
            midCross.color = new Color(1f, 1f, 1f, 1f);
        }
        if (mistakeCounter == 3)
        {
            rightCross.color = new Color(1f, 1f, 1f, 1f);
            menu.ActivateEndMenu();
        }

        musicManager.UpdateMusicPlayer(mistakeCounter);

        

    }

    void CrossInit()
    {
        Debug.Log("XD?????");
        Color color = new Color(50f/255f, 45f/255f, 45f/255f, 255f/255f);
        Debug.Log(color);
        leftCross.color = color;
        Debug.Log(leftCross.color);
        midCross.color = color;
        rightCross.color = color;

    }
}
