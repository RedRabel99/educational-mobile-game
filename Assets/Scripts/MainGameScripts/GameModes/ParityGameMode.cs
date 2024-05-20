using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ParityGameMode : GameMode
{
    private string evenText;
    private string oddText;
    public void Awake()
    {
        CurrentGameMode = new int[] {Random.Range(0, 2)};
        evenText = LocalizationSettings.StringDatabase.GetLocalizedString("evenText");
        oddText = LocalizationSettings.StringDatabase.GetLocalizedString("oddText");
    }

    public override void SetGameMode()
    {
        CurrentGameMode[0] = CurrentGameMode[0] == 0 ? 1 : 0;
    }

    public override string GetGameModeName()
    {
        if (CurrentGameMode[0] == 0) return evenText;
        else return oddText;
    }
}
