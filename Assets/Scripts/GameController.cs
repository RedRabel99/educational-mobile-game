using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;

public class GameController : MonoBehaviour
{
    [SerializeField] FallingObject.FallingObject ObjectToSpawn;
    public const float LEFT_SIDE_X = -4.0f;
    public const float RIGHT_SIDE_X = 4.0f;
    public const float SPAWN_HEIGHT = 10.0f;
    public double timeBeetwinSpawns;
    public double lastSpawnTime;
    void Start()
    {
        timeBeetwinSpawns = 2.0;
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
            float spawnWidth = Random.Range(LEFT_SIDE_X, RIGHT_SIDE_X);
            Vector3 spawningPosition = new Vector3(spawnWidth, SPAWN_HEIGHT, 0f);
            Instantiate(ObjectToSpawn, spawningPosition, transform.rotation);
        }
        
    }
}
