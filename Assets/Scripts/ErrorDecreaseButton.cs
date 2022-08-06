using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorDecreaseButton : MonoBehaviour
{
    public GameController controller;

    public void onButtonPressed()
    {
        if (controller.mistakeCounter.AreThereMistakes())
        {
            if (!controller.buffSystem.isBuffAvailable(Convert.ToInt32(ButtonNames.Error))) return;
            controller.mistakeCounter.DecreaseMistakeValue();
            controller.buffSystem.DecreaseBuffAmount(Convert.ToInt32(ButtonNames.Error));
            controller.buffSystem.SetActiveButtons();
            controller.buffSystem.UpdateBuffAmountTexts();
        }
    }
  
}
