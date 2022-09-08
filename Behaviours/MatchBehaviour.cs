using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class MatchBehaviour : MonoBehaviour
{
   public IDSO idObj;
   public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
   
   private IEnumerator OnTriggerEnter(Collider other)
   {
       
       var tempObj = other.GetComponent<IDContainerBehaviour>();
       if (tempObj == null) yield break;

       var otherID = tempObj.idObj;
       if (otherID == idObj)
       {
           matchEvent.Invoke();
       }
       else
       {
          noMatchEvent.Invoke();
          yield return new WaitForSeconds(.05f);
          noMatchDelayedEvent.Invoke();
       }
   } 
}
