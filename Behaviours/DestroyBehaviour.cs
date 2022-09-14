using System.Collections;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsobj;
   private IEnumerator Start()
   {
       wfsobj = new WaitForSeconds(seconds);
       yield return wfsobj;
       Destroy(gameObject);
   }
}
