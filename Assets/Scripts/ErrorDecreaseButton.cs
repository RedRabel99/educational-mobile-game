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
            controller.mistakeCounter.DecreaseMistakeValue();
        }
    }
  
}
