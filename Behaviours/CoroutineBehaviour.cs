using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{

    public UnityEvent startEvent, repeatEvent, endEvent;
    
    public IntData counterNum;
    
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuobj;
    public float seconds = 3.0f;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuobj = new WaitForFixedUpdate();
        
        startEvent.Invoke();
        while (counterNum.value > 0)
        {
           repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endEvent.Invoke();
    }
}
