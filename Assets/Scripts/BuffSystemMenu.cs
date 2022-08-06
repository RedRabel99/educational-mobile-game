using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuffSystemMenu : MonoBehaviour
{
    [SerializeField] TMP_Text ErrorBuffAmountText;
    [SerializeField] TMP_Text ScoreBuffAmountText;
    [SerializeField] TMP_Text TimeSlowBuffAmountText;
    [SerializeField] CoinSystem coinSystem;

    private void Start()
    {
        updateBuffAmountTexts();
    }
    void updateBuffAmountTexts()
    {
        ErrorBuffAmountText.text = $"{PlayerPrefs.GetInt("ErrorBuff", 0)}";
        ScoreBuffAmountText.text = $"{PlayerPrefs.GetInt("ScoreBuff", 0)}";
        TimeSlowBuffAmountText.text = $"{PlayerPrefs.GetInt("TimeBuff", 0)}";
    }

    public void BuyErrorBUff()
    {
        if (coinSystem.CoinAmount >= 30)
        {
            coinSystem.UpdateCoinAmount(-30);
            PlayerPrefs.SetInt("ErrorBuff", PlayerPrefs.GetInt("ErrorBuff", 0) + 1);
            updateBuffAmountTexts();
        }
    }

    public void BuyScoreBUff()
    {
        if (coinSystem.CoinAmount >= 50)
        {
            coinSystem.UpdateCoinAmount(-50);
            PlayerPrefs.SetInt("ScoreBuff", PlayerPrefs.GetInt("ScoreBuff", 0) + 1);
            updateBuffAmountTexts();
        }
    }

    public void BuyTimeBUff()
    {
        if (coinSystem.CoinAmount >= 40)
        {
            coinSystem.UpdateCoinAmount(-40);
            PlayerPrefs.SetInt("TimeBuff", PlayerPrefs.GetInt("TimeBuff", 0) + 1);
            updateBuffAmountTexts();
        }
    }
}
