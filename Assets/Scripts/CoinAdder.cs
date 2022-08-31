using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinAdder : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField] TMP_Text addedCoinsText;
    [SerializeField][Range(1, 5)] int multiplier;

    int CalculateCoinIncome(int score, int mistakes)
    {
        int result = score * multiplier - mistakes;
        return result > 0 ? result : 0;
    }

    void UpdateCoinText(int coinsAdded)
    {
        addedCoinsText.text = $"+{coinsAdded}";
    }

    void SaveAddedCoins(int coinsAdded)
    {
        int currentCoinAmount = PlayerPrefs.GetInt("coins", 0);
        PlayerPrefs.SetInt("coins", currentCoinAmount + coinsAdded);
    }

    public void AddCoins(int score, int mistakes = 0)
    {
        int coinIncome = CalculateCoinIncome(score, mistakes);
        UpdateCoinText(coinIncome);
        SaveAddedCoins(coinIncome);
    }
}
