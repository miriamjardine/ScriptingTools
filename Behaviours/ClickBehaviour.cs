using System.Collections;
using UnityEngine;

public class ClickBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float seconds = 1;
    private WaitForSeconds wfsobj;
    public void OnMouseDown()
    {
        prefab.SetActive(false);
        WaitToDestroy();
    }
    
    private IEnumerator WaitToDestroy()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
    }
    
}
