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

    void Start()
    {
        spawnBorders = new SpawnBorders(gameController.mainCamera);
        lastSpawnTime = Time.time;
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
            Debug.Log("LEFT " + spawnBorders.LeftScreenBorder);
            float randomWidth = Random.Range(spawnBorders.LeftScreenBorder, spawnBorders.RightScreenBorder);
            Vector3 spawningPosition = new Vector3(randomWidth, SPAWN_HEIGHT, 0f);
            Instantiate(gameController.ObjectToSpawn, spawningPosition, transform.rotation);
        }

    }
}
