using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingObject
{
    public abstract class FallingObject : MonoBehaviour
    {
        public abstract bool IsCorrect(int gameMode);

        public abstract void Destroy();
    }
}