using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FallingGameObject : MonoBehaviour
{
    protected int value;
    public abstract bool IsCorrect(GameMode gameMode);
    protected abstract void InitializeObjectSettings();

    private void Start()
    {
        InitializeObjectSettings();
    }
}