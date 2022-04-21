using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollisions : MonoBehaviour
{
    [SerializeField] MonsterBehavior monsterBehavior;

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
            monsterBehavior.gameController.score.UpdateScore();
        }
        else
        {
           monsterBehavior.gameController.mistakeCounter.IncreaseMistakeValue();
        }

    }
}
