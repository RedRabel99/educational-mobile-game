using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeSlowTimer : BuffTimer
{
    public override void OnBuffStart()
    {
        if (isRunning) return;
        timeSlider.gameObject.SetActive(true);
        currentBuffTime = Time.time;
        SlowwAllFallingObjects();
        isRunning = true;
    }

    protected override void OnBuffStop()
    {
        Debug.Log("ONBUFFSTOP");
        RemoveSlowFallingObjects();
        timeSlider.value = buffTime;
        timeSlider.gameObject.SetActive(false);
        isRunning = false;
    }

    void SlowwAllFallingObjects()
    {
        gameController.fallingObjectSpawner.isSlowed = true;
        gameController.fallingObjectSpawner.timeBeetwinSpawns *= 2;
        GameObject[] fallingObjects = GameObject.FindGameObjectsWithTag("FallingObject");

        foreach (var fallingObject in fallingObjects)
        {
            fallingObject.GetComponent<Rigidbody2D>().drag = 4;
        }
    }

    void RemoveSlowFallingObjects()
    {
        gameController.fallingObjectSpawner.isSlowed = false;
        gameController.fallingObjectSpawner.timeBeetwinSpawns /= 2;
        GameObject[] fallingObjects = GameObject.FindGameObjectsWithTag("FallingObject");

        foreach (var fallingObject in fallingObjects)
        {
            fallingObject.GetComponent<Rigidbody2D>().drag = 1.1f;
        }
    }
}
