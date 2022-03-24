using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;
using TMPro;

public class MonsterBehavior : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Rigidbody2D monsterBody;
    private Vector3 cursorPosition;
    public TMP_Text scoreValue;
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        monsterBody = this.GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0f, -7f, 0f);
        Cursor.visible = false;
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cursorPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorPosition.x, -7f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(collision.gameObject);
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreValue.text = $"SCORE:\n{++_score}";
    }
}
