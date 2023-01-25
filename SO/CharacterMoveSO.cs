using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterMoveSO : ScriptableObject
{
   [HideInInspector] public Vector3 inputs;
   protected 
   public string hAxis = "Horizontal", vAxis = "Vertical";
   public float speed = 1f, gravity = 3f, jumpForce = 20f;
   public int jumpCountMin = 0, jumpCountMax = 2;

   public abstract void Move(CharacterController character);

}
