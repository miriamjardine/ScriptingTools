using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public Rigidbody otherRb;
    public void Transform(Collider other)
   {
       var transformObj = other.transform;
       transformObj.parent = transform;
        transformObj.position = transformObj.parent.position;
        transformObj.parent = transform; 

        otherRb.useGravity = false;
   }

    public void DropPickup()
    {
        otherRb.useGravity=true;
        transform.DetachChildren();
    }

}
