using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovementBehaviour2halfD : MonoBehaviour
{
   private CharacterController charctrl;
   private Vector3 movement;
   public float speed;
   private float jumpHeight = 3f;
   private float gravity = 4f;
   private int jumpCount = 0;
   private int jumpCountMax = 2;


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
       movement *= speed;
       movement *= Time.deltaTime;
       charctrl.Move(movement);
       
     
           if (Input.GetKeyDown(KeyCode.W) && jumpCount < jumpCountMax)
           {
               movement.y = jumpHeight;
               Debug.Log("Jump Method Complete");
               jumpCount++;
           }
           movement.y -= gravity*Time.deltaTime;
           charctrl.Move(movement);

           if (charctrl.isGrounded)
           {
               movement.y = 0;
               jumpCount = 0;
           }
   }
   
  

} 
