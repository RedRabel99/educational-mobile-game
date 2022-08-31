using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParityGameMode : GameMode
{

    public void Awake()
    {
        CurrentGameMode = new int[] {Random.Range(0, 2)};
    }

    public override void SetGameMode()
    {
        CurrentGameMode[0] = CurrentGameMode[0] == 0 ? 1 : 0;
    }

    public override string GetGameModeName()
    {
        if (CurrentGameMode[0] == 0) return "PARZYSTE";
        else return "NIEPARZYSTE";
    }
}
