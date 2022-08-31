using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreaterLesserGameMode : GameMode
{
    public override string GetGameModeName()
    {
        string greaterOrLesser = CurrentGameMode[1] == 0 ? "WIÊKSZE" : "MNIEJSZE";
        return $"{greaterOrLesser} NI¯ {CurrentGameMode[0]}";
    }

    public override void SetGameMode()
    {
        CurrentGameMode[1] = DrawGreaterorLesser();
        CurrentGameMode[0] = DrawNumber(CurrentGameMode[1]);
    }

    // Start is called before the first frame update
    void Awake()
    {
        
        CurrentGameMode = new int[2];
        int initialGameMode = DrawGreaterorLesser();
        int initialNumber = DrawNumber(initialGameMode);
        CurrentGameMode[1] = initialGameMode;
        CurrentGameMode[0] = initialNumber;
    }

    int DrawNumber(int inequality)
    {
        List<int> nextPossibleNumbers = new List<int>();

        for(int i = 1; i < 10; i++)
        {
            if(IsTheSame(inequality, i) || IsTooLowOrHigh(inequality, i))
            {
                Debug.Log("ERORR + " + i);
                continue;
            }
                nextPossibleNumbers.Add(i);
            
        }
        foreach(int number in nextPossibleNumbers)
        {
            Debug.Log(number + "XSDXXXX");

        }
        Debug.Log(nextPossibleNumbers.Count);
        int drawIndex = Random.Range(0, nextPossibleNumbers.Count);
        Debug.Log("Draw index " + drawIndex);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
