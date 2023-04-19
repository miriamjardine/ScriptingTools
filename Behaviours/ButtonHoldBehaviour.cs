using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonHoldBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent onHoldEvent;
    public float holdTime = 0.5f;

    private bool buttonPressed = false;
    private float holdTimer = 0f;

    void Update()
    {
        if (buttonPressed)
        {
            holdTimer += Time.deltaTime;
            if (holdTimer >= holdTime)
            {
                onHoldEvent.Invoke();
                holdTimer = 0f;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        holdTimer = 0f;
    }
    
    public void OnHold()
    {
        Debug.Log("Button held down!");
    }
}