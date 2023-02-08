using UnityEngine;
using UnityEngine.Events;


public class TriggerExitEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerExitEvent;
   
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
   
   
}