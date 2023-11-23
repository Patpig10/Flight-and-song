using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMovement : MonoBehaviour
{
    public float speed = 5.0f;  // Movement speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy ship forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
