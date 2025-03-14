using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    [SerializeField] MonsterBehavior monsterBehavior;
    SpawnBorders screenBorders;
    
    void Start()
    {
        SetInitialPosition();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMonsterPosition();
    }

    void UpdateMonsterPosition()
    {
        if (monsterBehavior.gameController.pauseMenu.isPaused) return;
        Vector2 inputPosition = monsterBehavior.touchControls.Touch.TouchPosition.ReadValue<Vector2>();
        Vector3 inWorldInputPosition = monsterBehavior.mainCamera.ScreenToWorldPoint(inputPosition);

        transform.position = new Vector3(inWorldInputPosition.x, -6.3f, 0f);
    }

    void SetInitialPosition()
    {
        screenBorders = new SpawnBorders(monsterBehavior.mainCamera);
        transform.position = new Vector3(0f, -6.3f, 0f);
    }
}
