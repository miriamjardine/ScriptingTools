using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovementBehaviour : MonoBehaviour
{
   private CharacterController charctrl;
   private Vector3 movement;
   public FloatData speed;
   public FloatData jumpForce;

   public enum AxisInputs
   {
      Horizontal
   }

   public enum OtherInputs
   {
       Jump
   }

   public AxisInputs horizontalInput = AxisInputs.Horizontal; 
                    
   private void Awake()
   {
       charctrl = GetComponent<CharacterController>();
   }

   private void Update()
   {
       movement.Set(Input.GetAxis(horizontalInput.ToString()), 
                    0, 
                    0);
       movement *= speed.value;
       movement *= Time.deltaTime;
       charctrl.Move(movement);
   }

  

}
