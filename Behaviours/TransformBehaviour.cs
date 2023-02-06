using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public void Transform(Collider other)
   {
        var transformObj = other.transform;
        transformObj.parent = transform;
       // transformObj.localPosition = (UnityEngine.Vector3.zero);
   }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.DetachChildren();
        }
    }

}
