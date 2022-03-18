using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Rigidbody2D monsterBody;
    private Vector3 cursorPosition;
    // Start is called before the first frame update
    void Start()
    {
        monsterBody = this.GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0f, -8.5f, 0f);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        cursorPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorPosition.x, -8.5f, 0f);
    }
}
