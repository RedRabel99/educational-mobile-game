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
    public bool isSlowed;

    void Start()
    {
        spawnBorders = new SpawnBorders(gameController.mainCamera);
        lastSpawnTime = Time.time;
        CanSpawn = true;
        isSlowed= false;
    }

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
            FallingGameObject spawnedObject = Instantiate(gameController.ObjectToSpawn, spawningPosition, transform.rotation);
            if(isSlowed) spawnedObject.gameObject.GetComponent<Rigidbody2D>().drag = 4f;
        }
    }
}
