using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingObject
{
    public abstract class FallingObject : MonoBehaviour
    {
        public abstract bool IsCorrect(GameMode gameMode);
        public abstract void Destroy();
    }
}