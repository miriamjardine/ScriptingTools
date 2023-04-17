using UnityEngine;
using UnityEngine.UIElements;

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

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            otherRb.useGravity=true;
            transform.DetachChildren();
        }
    }

}
