using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health points
    public int currentHealth; // Current health points

    public int damageAmount = 10; // Amount of damage dealt on contact

    private GameManager gameManager;
    public int pointValue;

    void Start()
    {
        // Initialize current health to maximum health
        currentHealth = maxHealth;

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Method to take damage
    public void TakeDamage(int amount)
    {
        // Reduce current health by the specified amount
        currentHealth -= amount;

        // Check if health has reached zero or below
        if (currentHealth <= 0)
        {
            Die(); // Call the Die method if health is depleted
        }
    }

    // Method to handle death
    void Die()
    {
        // Perform any actions related to death, such as destroying the GameObject
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a Health component
        Health otherHealth = other.GetComponent<Health>();

        // If the colliding object has a Health component, deal damage to it
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageAmount);
        }
    }
}