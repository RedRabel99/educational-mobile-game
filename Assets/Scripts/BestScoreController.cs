using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization.Settings;

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
    private string _newRecordText;
    private string _defaultRecordText;
    const string BEST_SCORE_KEY_STRING = "BestScore";
    public BestScoreType bestScoreType;
    [SerializeField] TMP_Text recordText;
    string[] bestScoreKeys = { "ParityBestScore", "FiguresBestScore", "LesserGreaterBestScore" };

    void Awake()
    {
        _newRecordText = LocalizationSettings.StringDatabase.GetLocalizedString("newRecordText");
        _defaultRecordText =  LocalizationSettings.StringDatabase.GetLocalizedString("bestScoreText");
    }
    
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
            recordText.text = _newRecordText;
            SetBestScore(currentScore);
            return;
        }
        recordText.text = _defaultRecordText + $"{GetBestScore()}";
    }
}
