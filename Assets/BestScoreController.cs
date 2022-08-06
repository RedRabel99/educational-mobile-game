using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BestScoreType
{
    Parity,
    Figures,
    LesserOrGreater
}

public class BestScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameController gameController;
    const string NEW_RECORD_TEXT = "NOWY NAJLEPSZY WYNIK!";
    const string DEFAULT_RECORD_TEXT = "NAJLEPSZY WYNIK: ";
    const string BEST_SCORE_KEY_STRING = "BestScore";
    public BestScoreType bestScoreType;
    [SerializeField] TMP_Text recordText;
    string[] bestScoreKeys = { "ParityBestScore", "FiguresBestScore", "LesserGreaterBestScore" };


    int GetBestScore()
    {
        return PlayerPrefs.GetInt(bestScoreKeys[(int)bestScoreType], 0);
    }
    
    void SetBestScore(int currentScore)
    {
        PlayerPrefs.SetInt(bestScoreKeys[(int)bestScoreType], currentScore);
    }

    public bool WasBestScoreBeaten(int currentScore)
    {
        return PlayerPrefs.GetInt(bestScoreKeys[(int)bestScoreType], 0) < currentScore;
    }

    public void SetBestScoreText(int currentScore)
    {
        if (WasBestScoreBeaten(currentScore))
        {
            recordText.text = NEW_RECORD_TEXT;
            SetBestScore(currentScore);
            return;
        }
        recordText.text = DEFAULT_RECORD_TEXT + $"{GetBestScore()}";
    }
}
