
using UnityEngine;

[CreateAssetMenu]
public class PickupSO : ScriptableObject
{
   private GameObject gameObj;
   private Transform transformObj;
   private Rigidbody rb;
   private bool canPickup;

   public void OnPickup()
   {
      if (Input.GetKeyDown(KeyCode.K))
      {
         Destroy(gameObj);
      }
      
   }
}
