using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonBehaviour : MonoBehaviour
{
    public UnityEvent onClickDelayEvent;

    private IEnumerable<WaitForSeconds> Awake()
    {
        onClickDelayEvent.Invoke();
        yield return new WaitForSeconds(3f);
        onClickDelayEvent.Invoke();
    }
}
