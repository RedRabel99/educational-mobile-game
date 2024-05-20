using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class GreaterLesserGameMode : GameMode
{
    private string greaterText;
    private string lesserText;
    private string thanText;
    void Awake()
    {
        CurrentGameMode = new int[2];
        int initialGameMode = DrawGreaterorLesser();
        int initialNumber = DrawNumber(initialGameMode);
        CurrentGameMode[1] = initialGameMode;
        CurrentGameMode[0] = initialNumber;
        greaterText = LocalizationSettings.StringDatabase.GetLocalizedString("greaterText");
        lesserText = LocalizationSettings.StringDatabase.GetLocalizedString("lesserText");
        thanText = LocalizationSettings.StringDatabase.GetLocalizedString("thanText");
    }
    public override string GetGameModeName()
    {
        string greaterOrLesser = CurrentGameMode[1] == 0 ? greaterText : lesserText;
        return $"{greaterOrLesser} {thanText} {CurrentGameMode[0]}";
    }

    public override void SetGameMode()
    {
        CurrentGameMode[1] = DrawGreaterorLesser();
        CurrentGameMode[0] = DrawNumber(CurrentGameMode[1]);
    }

    int DrawNumber(int inequality)
    {
        List<int> nextPossibleNumbers = new List<int>();

        for(int i = 1; i < 10; i++)
        {
            if(IsTheSame(inequality, i) || IsTooLowOrHigh(inequality, i))
            {
                continue;
            }
                nextPossibleNumbers.Add(i);
            
        }
        int drawIndex = Random.Range(0, nextPossibleNumbers.Count);
        return nextPossibleNumbers[drawIndex];
    }

    bool IsTheSame(int inequality, int currentNumber)
    {
        return (CurrentGameMode[1] == inequality && CurrentGameMode[0] == currentNumber);
    }

    bool IsTooLowOrHigh(int inequality, int currentNumber)
    {
        if (inequality == 0) return currentNumber == 9;
        else return currentNumber == 1;
    }

    int DrawGreaterorLesser()
    {
        return Random.Range(0, 2);
    }
}
