using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFigure : FallingGameObject
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] squares;
    [SerializeField] Sprite[] circles;
    [SerializeField] Sprite[] triangles;
    int AMOUNT_OF_FIGURES = 3;
    List<Sprite[]> sprites;
    public override bool IsCorrect(GameMode gameMode)
    {
        int figureType = gameMode.CurrentGameMode[0];
        return value == figureType;
    }

    void InitList()
    {
        sprites = new List<Sprite[]>();
        sprites.Add(squares);
        sprites.Add(triangles);
        sprites.Add(circles);
    }

    void SetFigureType()
    {
        value = Random.Range(0, AMOUNT_OF_FIGURES);
        int randomSpriteIndex = Random.Range(0, sprites[value].Length);
        spriteRenderer.sprite = sprites[value][randomSpriteIndex];
    }

    protected override void InitializeObjectSettings()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        InitList();
        SetFigureType();
        gameObject.AddComponent<PolygonCollider2D>();
    }
}
