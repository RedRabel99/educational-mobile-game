using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectDestroyer : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool var = collision.gameObject.GetComponent<FallingObject.FallingObject>().IsCorrect(gameController.gameMode);

        Destroy(collision.gameObject);
        if (var)
        {
            UpdateScore();
        }
       
    }

    private void UpdateScore()
    {
        gameController.GetComponent<GameController>().mistakeCounter.IncreaseMistakeValue();
        gameController.musicManager.PlayErrorSound();
        gameController.monsterVisuals.StartMistakeAnimation();
    }
}
