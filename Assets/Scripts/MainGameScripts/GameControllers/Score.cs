using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int _scoreValue;
    [SerializeField] TMP_Text scoreValue;
    [SerializeField] TMP_Text endResult;
   // public int ScoreValue { get; set; }
    void Start()
    {
        _scoreValue = 0;
    }


    internal void UpdateScore()
    {
        scoreValue.text = $"WYNIK:\n{++_scoreValue}";
        endResult.text = $"WYNIK KONCOWY\n{_scoreValue}";
    }
}

