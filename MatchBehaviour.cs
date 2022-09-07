using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
   public IDSO idObj;
   
   
   private void OnTriggerEnter(Collider other)
   {
       
       var tempObj = other.GetComponent<IDContainerBehaviour>();
       if (tempObj == null) return;

       var otherID = tempObj.idObj;
       if (otherID == idObj)
       {
           Debug.Log("Match");
       }
       else
       {
           Debug.Log("No Match");
       }
   } 
}
