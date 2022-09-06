using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, enableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2.5f);
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnEnable()
    {
        enableEvent.Invoke();
    }
}

