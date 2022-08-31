using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollisions : MonoBehaviour
{
    [SerializeField] MonsterBehavior monsterBehavior;
    [SerializeField] GameController gameController;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool var = collision.gameObject.GetComponent<FallingObject.FallingObject>().IsCorrect(monsterBehavior.gameController.gameMode);
        Debug.Log(collision.name);
        Destroy(collision.gameObject);
        if (var)
        {
            gameController.musicManager.PlayScoreSound();
            monsterBehavior.gameController.score.UpdateScore();
        }
        else
        {
           gameController.musicManager.PlayErrorSound();
           gameController.monsterVisuals.StartMistakeAnimation();
           monsterBehavior.gameController.mistakeCounter.IncreaseMistakeValue();
        }

    }
}
