using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{

    public void PauseFallingObjects()
    {
        GameObject[] fallingObjects = GameObject.FindGameObjectsWithTag("FallingObject");

        foreach (var fallingObject in fallingObjects)
        {
            fallingObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    public void UnpauseFallingObjects()
    {
        GameObject[] fallingObjects = GameObject.FindGameObjectsWithTag("FallingObject");

        foreach (var fallingObject in fallingObjects)
        {
            Debug.Log(fallingObject.name + "??????");
            fallingObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
    }
}
