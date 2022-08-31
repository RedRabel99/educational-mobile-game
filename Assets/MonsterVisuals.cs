using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterVisuals : MonoBehaviour
{
    [SerializeField] SpriteRenderer[] monsterParts;
    
    void SetColorRed()
    {
        foreach(var part in monsterParts)
        {
            part.color = new Color(1f, 0f, 0f, 1f);
        }
    }

    void SetDefaultColor()
    {
        foreach(var part in monsterParts)
        {
            part.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    public void StartMistakeAnimation()
    {
        SetColorRed();
        Invoke("SetDefaultColor", 0.2f);
    }
}
