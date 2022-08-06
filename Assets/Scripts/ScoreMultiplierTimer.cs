using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplierTimer : BuffTimer
{
    public override void OnBuffStart()
    {
        if (isRunning) return;
        Debug.Log("?????????????? " + !gameController.buffSystem.isBuffAvailable(Convert.ToInt32(ButtonNames.Score)));
        if (!gameController.buffSystem.isBuffAvailable(Convert.ToInt32(ButtonNames.Score))) return;
        gameController.buffSystem.DecreaseBuffAmount(Convert.ToInt32(ButtonNames.Score));
        gameController.buffSystem.UpdateBuffAmountTexts();
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
        gameController.buffSystem.SetActiveButtons();
        isRunning = false;
    }
}
