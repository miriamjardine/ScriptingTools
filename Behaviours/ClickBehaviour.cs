using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ClickBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float seconds = 1;
    private WaitForSeconds wfsobj;
    public UnityEvent onClickEvent, noClickEvent;
    
    public void OnMouseDown()
    {
        onClickEvent.Invoke();
    }

    public void OnMouseUp()
    {
        Destroy(gameObject);
    }

    public void NoClickEvent()
    {
        noClickEvent.Invoke();
    }
    
    private IEnumerator WaitToDestroy()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
    }
    
    
}
