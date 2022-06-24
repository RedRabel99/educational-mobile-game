using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{

    [SerializeField] TMP_Text[] coinTexts;
    int coinAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCoinTexts()
    {
        foreach(var text in coinTexts)
        {
            text.text = $"X{coinAmount}";
        }
    }

    public void SetCurrentCoinAmount()
    {
        coinAmount = PlayerPrefs.GetInt("coins", 0);
    }

    public void UpdtadeCoinAmount(int additionalAmount)
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0));
        coinAmount = PlayerPrefs.GetInt("coins", 0);
        UpdateCoinTexts();
    }
}
