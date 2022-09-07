using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public IDSO idObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }
}
