using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollisions : MonoBehaviour
{
    [SerializeField] MonsterBehavior monsterBehavior;
    [SerializeField] GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isCorrect = collision.gameObject
            .GetComponent<FallingGameObject>()
            .IsCorrect(monsterBehavior.gameController.gameMode);
        Destroy(collision.gameObject);
        if (isCorrect)
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
