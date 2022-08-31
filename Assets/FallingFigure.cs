using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFigure : FallingObject.FallingObject
{
    int value;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] squares;
    [SerializeField] Sprite[] circles;
    [SerializeField] Sprite[] triangles;
    int AMOUNT_OF_FIGURES = 3;
    List<Sprite[]> sprites;
    public override void Destroy()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsCorrect(GameMode gameMode)
    {
        int figureType = gameMode.CurrentGameMode[0];
        return value == figureType;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        InitList();
        SetFigureType();
        gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
