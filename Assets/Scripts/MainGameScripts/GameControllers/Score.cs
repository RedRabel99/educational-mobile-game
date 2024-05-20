using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization;

public class Score : MonoBehaviour
{
    private int _scoreValue;
    public int ScoreMultiplier;
    [SerializeField] GameController gameController;
    [SerializeField] TMP_Text scoreValue;
    [SerializeField] TMP_Text endResult;
    [SerializeField] private LocalizedString localStringScore;

    [SerializeField] private LocalizedString localStringFinalScore;
   // public int ScoreValue { get; set; }
    void Start()
    {
        _scoreValue = 0;
        ScoreMultiplier = 1;
        localStringScore.Arguments = new object[] { _scoreValue };
        localStringFinalScore.Arguments = new object[] { _scoreValue };
        scoreValue.text = localStringScore.GetLocalizedString();
    }

    public int GetCurrentScore()
    {
        return _scoreValue;
    }

    internal void UpdateScore()
    {
        _scoreValue += ScoreMultiplier;
        localStringScore.Arguments[0] = _scoreValue;
        localStringFinalScore.Arguments[0] = _scoreValue;
        scoreValue.text = localStringScore.GetLocalizedString();
        //scoreValue.text = $"WYNIK:\n{_scoreValue}";
        
        //endResult.text = $"WYNIK KONCOWY\n{_scoreValue}";
        endResult.text = localStringFinalScore.GetLocalizedString();
        //localStringScore.RefreshString();
        gameController.fallingObjectSpawner.timeBeetwinSpawns -= 0.01;
    }
}

