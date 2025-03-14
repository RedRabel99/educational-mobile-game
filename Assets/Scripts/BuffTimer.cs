using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BuffTimer : MonoBehaviour
{
    [SerializeField] protected Slider timeSlider;
    [SerializeField] protected float buffTime;
    protected float currentBuffTime;
    public GameController gameController;
    protected bool isRunning;

    public abstract void OnBuffStart();
    protected abstract void OnBuffStop();
    
    void Start()
    {
        isRunning = false;
        timeSlider.maxValue = buffTime; 
        timeSlider.gameObject.SetActive(false);
    }

    void Update()
    {
        float currentTime = Mathf.Abs(currentBuffTime - Time.time);
        if (isRunning)
        {
            if (currentTime >= buffTime)
            {
                OnBuffStop();
                return;
            }
            timeSlider.value = buffTime - currentTime;
            
        }
    }
}
