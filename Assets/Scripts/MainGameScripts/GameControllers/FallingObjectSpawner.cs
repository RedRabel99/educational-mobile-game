using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectSpawner : MonoBehaviour
{

    [SerializeField] GameController gameController;
    SpawnBorders spawnBorders;
    public double timeBeetwinSpawns;
    const float SPAWN_HEIGHT = 10f;
    float lastSpawnTime;
    public bool CanSpawn;
    //float timer;

    void Start()
    {
        spawnBorders = new SpawnBorders(gameController.mainCamera);
        lastSpawnTime = Time.time;
        CanSpawn = true;
    //    timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
       if(CanSpawn && !gameController.pauseMenu.isPaused) SpawnFallingObject();
    }

    void SpawnFallingObject()
    {
        if (Time.time - lastSpawnTime > timeBeetwinSpawns)
        {
            lastSpawnTime = Time.time;
            
            float randomWidth = Random.Range(spawnBorders.LeftScreenBorder, spawnBorders.RightScreenBorder);
            Vector3 spawningPosition = new Vector3(randomWidth, SPAWN_HEIGHT, 0f);
            Instantiate(gameController.ObjectToSpawn, spawningPosition, transform.rotation);
        }

    }

}
