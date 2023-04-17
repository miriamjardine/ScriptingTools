
using UnityEngine;
using UnityEngine.Events;

public class KeyBehaviour : MonoBehaviour
{
    public UnityEvent onQKey;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            onQKey.Invoke();
        }

    }

}
