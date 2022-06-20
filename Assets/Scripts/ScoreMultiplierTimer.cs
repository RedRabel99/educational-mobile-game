using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplierTimer : BuffTimer
{
    public override void OnBuffStart()
    {
        if (isRunning) return;
        timeSlider.gameObject.SetActive(true);
        currentBuffTime = Time.time;
        gameController.score.ScoreMultiplier = 2;
        isRunning= true;
    }

    protected override void OnBuffStop()
    {
        Debug.Log("ONBUFFSTOP");
        gameController.score.ScoreMultiplier = 1;
        timeSlider.value = buffTime;
        timeSlider.gameObject.SetActive(false);
        isRunning = false;
    }
}
