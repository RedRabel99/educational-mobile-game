using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FallingObject;

public class GameController : MonoBehaviour
{
    public FallingObject.FallingObject ObjectToSpawn;
    public PauseMenu menu;
    public Score score;
    public MistakeCounter mistakeCounter;
    public Camera mainCamera;
    void Start()
    {
 
    }
}
