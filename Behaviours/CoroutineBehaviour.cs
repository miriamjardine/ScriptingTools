using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{

    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
    
    public IntData counterNum;
    public bool canRun;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuobj;
    public float seconds = 3.0f;


    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }
    public void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();

        startEvent.Invoke();   
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
           repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}
