using UnityEngine;

public class Circle : MonoBehaviour
{
    public Transform cube; // Reference to the Cube object
    public float rollForce = 10f; // Magnitude of the force to roll towards the Cube
    public float points = 10;

    private Rigidbody rb; // Reference to the Rigidbody component

    void Start()
    {
        // Get the Rigidbody component attached to the Circle enemy
        rb = GetComponent<Rigidbody>();

        // Ensure that the Cube reference is set
        if (cube == null)
        {
            Debug.LogError("Cube reference is not set. Assign the Cube object in the inspector.");
        }
    }

    void FixedUpdate()
    {
        // Check if the Rigidbody component and Cube reference are valid
        if (rb != null && cube != null)
        {
            // Calculate the direction towards the Cube
            Vector3 directionToCube = (cube.position - transform.position).normalized;

            // Apply force towards the Cube
            rb.AddForce(directionToCube * rollForce, ForceMode.Force);
        }
    }
}