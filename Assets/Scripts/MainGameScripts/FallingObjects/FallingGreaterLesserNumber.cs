using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FallingGreaterLesserNumber : FallingGameObject
{
    [SerializeField] TMP_Text valueText;

    public override bool IsCorrect(GameMode gameMode)
    {

        int greaterOrLesser = gameMode.CurrentGameMode[1];
        int objectiveValue = gameMode.CurrentGameMode[0];

        if (greaterOrLesser == 0) return value > objectiveValue;
        else return value < objectiveValue;
    }

    void setValues()
    {
        value = Random.Range(1, 10);
        valueText.text = value.ToString();
    }

    protected override void InitializeObjectSettings()
    {
        setValues();
    }
}

