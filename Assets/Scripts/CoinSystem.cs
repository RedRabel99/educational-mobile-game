using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{

    [SerializeField] TMP_Text[] coinTexts;
    int coinAmount;
    public int CoinAmount { get { return coinAmount; } }

    void Start()
    {
        SetCurrentCoinAmount();
        UpdateCoinTexts();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("BPRESSED");
            UpdateCoinAmount(100);
            UpdateCoinTexts();
        }
    }

    public void UpdateCoinTexts()
    {
        foreach(var text in coinTexts)
        {
            text.text = $"{coinAmount}";
        }
    }

    public void SetCurrentCoinAmount()
    {
        coinAmount = PlayerPrefs.GetInt("coins", 0);
    }

    public void UpdateCoinAmount(int additionalAmount)
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins", 0) + additionalAmount);
        coinAmount = PlayerPrefs.GetInt("coins", 0);
        UpdateCoinTexts();
    }
}
