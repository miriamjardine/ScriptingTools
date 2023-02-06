using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovementBehaviour2halfD : MonoBehaviour
{
   private CharacterController charctrl;
   private Vector3 movement;
   public float speed;
   private float jumpHeight = 3f;
   public float gravity = 7f;
   private int jumpCount = 0;
   private int jumpCountMax = 2;


   public enum AxisInputs
   {
      Horizontal, Vertical
   }
   

   public AxisInputs horizontalInput = AxisInputs.Horizontal, verticalInput = AxisInputs.Vertical; 
                    
   private void Awake()
   {
       charctrl = GetComponent<CharacterController>();
   }

   private void Update()
   {
       movement.Set(Input.GetAxis(horizontalInput.ToString()),  
                    0,
                    Input.GetAxis(verticalInput.ToString()));
       movement *= speed;
       movement *= Time.deltaTime;
       charctrl.Move(movement);
       
     
           if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
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
