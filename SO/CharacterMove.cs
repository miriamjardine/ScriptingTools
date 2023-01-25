using UnityEngine;

public abstract class CharacterMove : ScriptableObject
{
                                    //why inputs? Why do we need this? Do we?
   [HideInInspector] public Vector3 inputs;
  //Protected means that the data can only be accessed by something within the class
   protected Vector3 positionDirection;
   public string hAxis = "Horizontal", vAxis = "Vertical";
   public float speed = 10f, gravity = 3f, jumpForce = 30f;
   public int jumpCountMin = 0, jumpCountMax = 2;

   public float Speed
   {
       // I need to go over this part. Why do we need it and public float speed?
       get => speed;
       set => speed = value;
   }
   public abstract void Move(CharacterController character);

}
