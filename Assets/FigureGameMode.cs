using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureGameMode : GameMode
{
    public override string GetGameModeName()
    {
        switch (CurrentGameMode[0]) { 
            case 0:
                return "KWADRATY";
            case 1:
                return "TRÓJK¥TY";
            case 2:
                return "KO£A";
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

    // Start is called before the first frame update
    void Awake()
    {
        CurrentGameMode = new int[] {Random.Range(0,3)};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
