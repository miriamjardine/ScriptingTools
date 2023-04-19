using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
    public GameObject flipObj;

    public void RotateLeft()
    {

        Quaternion currentRotation = flipObj.transform.rotation;
        Quaternion newRotation = Quaternion.Euler(0f, 270f, 0f);
        flipObj.transform.rotation = newRotation;

    }
    
    public void RotateRight()
    {

        Quaternion currentRotation = flipObj.transform.rotation;
        Quaternion newRotation = Quaternion.Euler(0f, 90f, 0f);
        flipObj.transform.rotation = newRotation;

    }
}
