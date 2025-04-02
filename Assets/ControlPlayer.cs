using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Rotation speed
    public float moveSpeed = 5f;          // Movement speed
    float gravity = 8.5f;
   // Vector3 velocity;
 //   [SerializeField] CharacterController cc;

    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Lock cursor to center
    }

    void Update()
    {

        //Gravity

       // if(!cc.isGrounded)
       // {
        //    velocity.y += gravity*Time.deltaTime;   
      //      cc.Move(velocity);
    //    }

        // Get horizontal mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        // Rotate player left and right
        rotationY += mouseX;
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        // Move forward and backward based on player input
        float moveDirection = 0f;
        if (Input.GetKey(KeyCode.W))  // Move forward
        {
            moveDirection = 1f;
        }
        else if (Input.GetKey(KeyCode.S))  // Move backward
        {
            moveDirection = -1f;
        }

        // Apply movement relative to the player's current facing direction
        transform.Translate(Vector3.forward * moveDirection * moveSpeed * Time.deltaTime);
    }
}