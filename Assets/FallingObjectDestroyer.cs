using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectDestroyer : MonoBehaviour
{

    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool var = collision.gameObject.GetComponent<FallingObject.FallingObject>().IsCorrect(0);

        Debug.Log($"TEST: {var}");
        Destroy(collision.gameObject);
        if (var)
        {
            UpdateScore();
        }
       
    }

    private void UpdateScore()
    {
        gameController.GetComponent<GameController>().IncreaseMistakeValue();
       // scoreValue.text = $"SCORE:\n{++_score}";
    }
}
