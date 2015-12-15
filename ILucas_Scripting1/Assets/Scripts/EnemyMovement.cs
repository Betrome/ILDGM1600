using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    PlayerHealth playerHealth;
    public NavMeshAgent nav;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.transform.position);
        }
    }
}
