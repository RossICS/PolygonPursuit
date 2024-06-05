using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{

    public float range = 5.0f; //How close the enemy has to be to the player to shoot.
    public float speed = 5; //How fast the enemy can move into that range.
    public float firerate = 20; //How fast it can shoot.
    public float bulletSpeed = 5; //How fast its bullets can move in the air.
    public float attackCooldown = 5; //How long it has to wait to shoot again.
    public float points = 20; //How

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= attackCooldown)
        {
            // Launch a projectile from the triangle
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            attackCooldown = Time.time + firerate; // Set the time for next shot
        }
    }
}
