using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ClickBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float seconds = 1;
    private WaitForSeconds wfsobj;
    public UnityEvent onClickEvent;
    
    public void OnMouseDown()
    {
        prefab.SetActive(false);
        onClickEvent.Invoke();
        WaitToDestroy();
    }
    
    private IEnumerator WaitToDestroy()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
    }
    
    
}
