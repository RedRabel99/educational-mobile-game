using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreMenuController : MonoBehaviour
{
    const string BEST_SCORE_KEY_STRING = "BestScore";
    [SerializeField] TMP_Text recordText;
    string[] bestScoreKeys = { "ParityBestScore", "FiguresBestScore", "LesserGreaterBestScore" };

    private void Start()
    {
        recordText.text = GetHighestRecord().ToString();
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
}
