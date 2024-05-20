using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectDestroyer : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isCorrect = collision.gameObject.GetComponent<FallingGameObject>().IsCorrect(gameController.gameMode);

        Destroy(collision.gameObject);
        if (isCorrect)
        {
            PerformMistakeAction();
        }
       
    }

    private void PerformMistakeAction()
    {
        gameController.GetComponent<GameController>().mistakeCounter.IncreaseMistakeValue();
        gameController.musicManager.PlayErrorSound();
        gameController.monsterVisuals.StartMistakeAnimation();
    }
}