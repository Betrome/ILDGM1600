using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    public GameObject player;                          // Reference to the player GameObject.
    PlayerHealth playerHealth;                  // Reference to the player's health.

    void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
    }


    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
            Attack();
    }


    void Attack()
    {

        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage();
        }
    }
}
