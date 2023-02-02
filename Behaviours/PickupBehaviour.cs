
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PickupBehaviour : MonoBehaviour
{
    public bool canPickup;
    public GameObject playerGameObj;
    
    private bool pickedUp = false;
    private Rigidbody rb;
    
    public UnityEvent pickupEvent, noPickupEvent, dropEvent;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        var transformObj = transform;
        
        if (canPickup == true && Input.GetKeyDown(KeyCode.K))
        {
            rb.isKinematic = true;
            transformObj.position = playerGameObj.transform.position;
            transformObj.parent = playerGameObj.transform;
            pickedUp = true;
            pickupEvent.Invoke();
            Debug.Log("Picked up");
        }

        if (canPickup == false && Input.GetKeyDown(KeyCode.K))
        {
            noPickupEvent.Invoke();
        }

        if (pickedUp == true && Input.GetKeyDown(KeyCode.K))
        {
            
        }
        
    }
    
}
