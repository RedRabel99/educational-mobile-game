using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FallingGreaterLesserNumber : FallingObject.FallingObject
{
    private int _value;
    public TMP_Text valueText;

    void Start()
    {
        setValues();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override bool IsCorrect(GameMode gameMode)
    {

        int greaterOrLesser = gameMode.CurrentGameMode[1];
        int objectiveValue = gameMode.CurrentGameMode[0];

        if (greaterOrLesser == 0) return _value > objectiveValue;
        else return _value < objectiveValue;
    }

    void setValues()
    {
        //valueText = this.gameObject.GetComponent < TextMeshPro>();
        _value = Random.Range(1, 10);
        valueText.text = _value.ToString();
    }


    public override void Destroy()
    {
        // Destroy(GameObject);

    }
}

