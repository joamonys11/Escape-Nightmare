using UnityEngine;

public class mouse : MonoBehaviour
{
    public float mouseSensitivity = 100f;  // Adjust to change speed
    public Transform playerBody;           // Assign the player or object to rotate

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Lock cursor to the center of the screen
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        // Rotate the player object left and right
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
