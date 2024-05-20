using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreMenuController : MonoBehaviour
{
    const string BEST_SCORE_KEY_STRING = "BestScore";
    [SerializeField] TMP_Text recordText;
    [SerializeField] TMP_Text parityRecordText;
    [SerializeField] TMP_Text figureRecordText;
    [SerializeField] TMP_Text greaterLesserRecordText;
    string[] bestScoreKeys = { "ParityBestScore", "FiguresBestScore", "LesserGreaterBestScore" };

    private void Start()
    {
        InitBestScoreTexts();
    }

    int GetHighestRecord()
    {
        int highestRecord = 0;
        foreach(var key in bestScoreKeys)
        {
            int currentTypeRecord = PlayerPrefs.GetInt(key, 0);

            if (highestRecord < currentTypeRecord) highestRecord = currentTypeRecord; 
        }
        return highestRecord;
    }

    void InitBestScoreTexts()
    {
        recordText.text = GetHighestRecord().ToString();
        SetAllBestScores();
    }
    void SetAllBestScores()
    {
        parityRecordText.text = PlayerPrefs.GetInt(bestScoreKeys[0], 0).ToString();
        figureRecordText.text = PlayerPrefs.GetInt(bestScoreKeys[1], 0).ToString();
        greaterLesserRecordText.text = PlayerPrefs.GetInt(bestScoreKeys[2], 0).ToString();
    }
}
