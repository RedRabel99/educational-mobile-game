using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class FigureGameMode : GameMode
{
    private string squaresText;
    private string trianglesText;
    private string circlesText;
    
    void Awake()
    {
        CurrentGameMode = new int[] {Random.Range(0,3)};
        squaresText = LocalizationSettings.StringDatabase.GetLocalizedString("squaresText");
        trianglesText = LocalizationSettings.StringDatabase.GetLocalizedString("trianglesText");
        circlesText = LocalizationSettings.StringDatabase.GetLocalizedString("circlesText");
    }
    
    public override string GetGameModeName()
    {
        switch (CurrentGameMode[0]) { 
            case 0:
                return squaresText;
            case 1:
                return trianglesText;
            case 2:
                return circlesText;
            default:
                return "XXXXX";
        }
    }

    public override void SetGameMode()
    {
        CurrentGameMode[0] = DrawNextGameMode();
    }

    int DrawNextGameMode()
    {
        int[] nextPossibleGameModes = new int[2];
        int j = 0;
        for (int i = 0; i < 3; i++)
        {
            if (i != CurrentGameMode[0])
            {
                nextPossibleGameModes[j++] = i;
            }
        }
        return nextPossibleGameModes[Random.Range(0, 2)];
    }
}
