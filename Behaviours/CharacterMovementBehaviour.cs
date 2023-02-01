using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovementBehaviour : MonoBehaviour
{
   private CharacterController charctrl;
   private Vector3 movement;
   public FloatData speed;
   public float jumpForce;
   public float gravity;
   private float jumpCount = 0;
   private float jumpCountMax = 2;

   public enum AxisInputs
   {
      Horizontal
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

       if (Input.GetKeyDown(KeyCode.S))
       {
           Jump();
       }
   }

   private void Jump()
   {
       if (charctrl.isGrounded)
       {
           movement.y = 0;
           jumpCount = 0;
       }

       if (jumpCount < jumpCountMax && Input.GetKeyDown(KeyCode.S))
       {
           movement.y = jumpForce;
           jumpCount++;
           movement.y -= gravity * Time.deltaTime;
           charctrl.Move(movement * Time.deltaTime);
       }
       
       Debug.Log("Jump Method Complete");

   }
  

}
