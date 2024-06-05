using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPain : MonoBehaviour
{
    public int damageAmount = 10; // Amount of damage the bullet inflicts

    void Start()
    {
        // Ignore collisions between the bullet and cube layers
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Bullet"), LayerMask.NameToLayer("Player"));
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a Health component
        Health health = collision.gameObject.GetComponent<Health>();

        if (health != null)
        {
            // If the collided object has a Health component, apply damage
            health.TakeDamage(damageAmount);
        }

        // Destroy the bullet regardless of whether it hit something or not
        Destroy(gameObject);
    }
}