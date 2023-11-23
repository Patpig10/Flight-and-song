using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public float speed = 5.0f;
    public float lifetime = 4.0f;

    private Transform player;
    private Vector3 directionToPlayer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player != null)
        {
            // Calculate the direction to the player
            directionToPlayer = (player.position - transform.position).normalized;
        }

        Invoke("DestroyObject", lifetime);
    }

    void Update()
    {
        // Move towards the player's last known position
        transform.Translate(directionToPlayer * speed * Time.deltaTime, Space.World);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}