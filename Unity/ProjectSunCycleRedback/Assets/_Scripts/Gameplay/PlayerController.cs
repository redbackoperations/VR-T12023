using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody rb;

    private void Start()
    {
        // Get the Rigidbody component attached to the bike GameObject
        rb = GetComponent<Rigidbody>();
        // Freeze rotation along the X and Z axes to prevent tumbling
        rb.freezeRotation = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        // Check for the "W" key press
        if (Input.GetKey(KeyCode.W))
        {
            // Move the cube in the camera's forward direction
            MoveForward();
        }
    }

    void MoveForward()
    {
        // Get the camera's forward direction
        Vector3 cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0; // To prevent the bike from moving in the Y-axis

        // Move the bike in the camera's forward direction
        transform.position += cameraForward.normalized * movementSpeed * Time.deltaTime;
    }
}
