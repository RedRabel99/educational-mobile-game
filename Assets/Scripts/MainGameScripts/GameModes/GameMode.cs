using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameMode : MonoBehaviour
{
    public int[] CurrentGameMode;

    public abstract void SetGameMode();
    public abstract string GetGameModeName();
}
