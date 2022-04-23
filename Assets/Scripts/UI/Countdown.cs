using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Countdown : MonoBehaviour
{
    //public int timer;
    [SerializeField] TMP_Text counter;
    public IEnumerator CountdownToStart(int timer)
    {
        gameObject.SetActive(true);
        counter.fontSize = 40;
        while (timer > 0)
        {
            counter.text = timer.ToString();

            yield return new WaitForSeconds(1f);
            timer--;
        }
        counter.fontSize = 25;
        counter.text = "START!";

        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);
      //  Time.timeScale = 1f;
    }
}
