using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorders
{
    public float LeftScreenBorder { get; }
    public float RightScreenBorder { get; }
    public SpawnBorders(Camera camera)
    {
        float left, right;
        right = camera.ScreenToWorldPoint(new Vector2(Screen.width, 0f)).x;
        left = -1f * right;

        LeftScreenBorder = left - (left * 0.1f);
        RightScreenBorder = right - (right * 0.1f);
    }
}
