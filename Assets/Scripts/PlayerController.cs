using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float horizontalInput;
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public GameObject projectilePrefab;
    public float fireRate = 0.25f;
    private float nextFireTime = 0f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                // Launch a projectile from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                nextFireTime = Time.time + fireRate; // Set the time for next shot
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        // Get horizontal input for movement
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the truck forward based on input
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}