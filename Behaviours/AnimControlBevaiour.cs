
using UnityEngine;
using UnityEngine.Events;

public class AnimControlBevaiour : MonoBehaviour
{
    public UnityEvent onMoveEvent, jumpEvent;
   public void Update()
   {
     if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
     {
         onMoveEvent.Invoke();
     }
     
     if (Input.GetKeyDown(KeyCode.Space))
     {
         jumpEvent.Invoke();
     }
   }
}
