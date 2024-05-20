using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ButtonNames
{
    Error,
    Score,
    Time
}

public class BuffSystemInGame : MonoBehaviour
{
    [SerializeField] Button[] buttons;
    [SerializeField] TMP_Text errorBuffAmountText;
    [SerializeField] TMP_Text scoreBuffAmountText;
    [SerializeField] TMP_Text timeSlowBuffAmountText;
    public int diff;


    private void Start()
    {
        UpdateBuffAmountTexts();
        SetActiveButtons();
    }

    private void Update()
    { /*
        if (Input.GetKey(KeyCode.B))
        {
            PlayerPrefs.SetInt("ErrorBuff", diff);
            PlayerPrefs.SetInt("ScoreBuff", diff);
            PlayerPrefs.SetInt("TimeBuff", diff);
        } */
    }

    public void SetButtonActive(int buttonId, bool isActive)
    {
        buttons[buttonId].interactable = isActive;
    }

    public bool isBuffAvailable(int buttonId)
    {
        Debug.Log($"Hello its id {buttonId} aadadada {PlayerPrefs.GetInt("ScoreBuff", 0)}");
        switch (buttonId) {         
            case(0):
                return PlayerPrefs.GetInt("ErrorBuff", 0) != 0;
            case (1):
                return PlayerPrefs.GetInt("ScoreBuff", 0) != 0;
            case (2):
                return PlayerPrefs.GetInt("TimeBuff", 0) != 0;
        default:
                return false;
        }
    }
    public void UpdateBuffAmountTexts()
    {
        errorBuffAmountText.text = $"X{PlayerPrefs.GetInt("ErrorBuff", 0)}";
        scoreBuffAmountText.text = $"X{PlayerPrefs.GetInt("ScoreBuff", 0)}";
        timeSlowBuffAmountText.text = $"X{PlayerPrefs.GetInt("TimeBuff", 0)}";
    }

    public void DecreaseBuffAmount(int buffId)
    {
        switch (buffId)
        {
            case(0):
                PlayerPrefs.SetInt("ErrorBuff", PlayerPrefs.GetInt("ErrorBuff", 0) - 1);
                break;
            case (1):
                PlayerPrefs.SetInt("ScoreBuff", PlayerPrefs.GetInt("ScoreBuff", 0) - 1);
                break;
            case (2):
                PlayerPrefs.SetInt("TimeBuff", PlayerPrefs.GetInt("TimeBuff", 0) - 1);
                break;
            default:
                return;
        }
    }

    public void SetActiveButtons()
    {
        if (PlayerPrefs.GetInt("ErrorBuff", 0) <= 0) SetButtonActive(0, false);
        if (PlayerPrefs.GetInt("ScoreBuff", 0) <= 0) SetButtonActive(1, false);
        if(PlayerPrefs.GetInt("TimeBuff", 0) <= 0) SetButtonActive(2, false);
    }
}
