using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;
using TMPro;
using UnityEngine.InputSystem;

public class MonsterBehavior : MonoBehaviour
{
    public Camera mainCamera;
    public MonsterMovement monsterMovement;
   [SerializeField] internal MonsterCollisions monsterCollisions;
    public TMP_Text scoreValue;
    public GameController gameController;
    public TouchControls touchControls;
    void Start()
    {
        Cursor.visible = false;
       touchControls = new TouchControls();
       touchControls.Enable();
    }

    void Update()
    {
    }
}
