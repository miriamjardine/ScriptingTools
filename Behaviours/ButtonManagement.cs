using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class ButtonManagement : MonoBehaviour
{
    private CharacterController charctrl;
    private Vector3 movement;
    public float speed;
    public float jumpHeight = 4f;
    public float gravity = 7f;
    private int jumpCount = 0;
    private int jumpCountMax = 2;
    
   
    private void Awake()
    {
        charctrl = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        // Apply gravity to the movement vector
        movement.y -= (gravity * Time.deltaTime) * 2;

        // Move the character controller using the movement vector
        charctrl.Move(movement * Time.deltaTime);

        // Reset the jump count if the character controller is grounded
        if (charctrl.isGrounded)
        {
            movement.y = 0;
            jumpCount = 0;
            Debug.Log("Jump grounded");
        }
    }
    
    public void onMoveRight()
    {
        movement = Vector3.zero;
        movement += Vector3.right * speed * Time.deltaTime;
        charctrl.Move(movement);
        Debug.Log("Move right");
    }

    public void onMoveLeft()
    {
        movement = Vector3.zero;
        movement += Vector3.left * speed * Time.deltaTime;
        charctrl.Move(movement);
        Debug.Log("Move left");
    }

    public void onJump()
    {
        if (jumpCount < jumpCountMax)
        {
            movement.y = jumpHeight;
            jumpCount++;
            Debug.Log("Jump began");
        }
    }

    

    
}
