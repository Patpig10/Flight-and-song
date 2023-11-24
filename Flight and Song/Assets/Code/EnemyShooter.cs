using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject ball;
    public GameObject pipe;
    public GameObject ring;
    public Transform[] attackPoints; // Array to hold attack points
    public float spawnInterval = 3.0f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // Choose a random attack point
            Transform randomAttackPoint = attackPoints[Random.Range(0, attackPoints.Length)];

            // Instantiate a random projectile at the chosen attack point
            SpawnRandomProjectile(randomAttackPoint);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnRandomProjectile(Transform attackPoint)
    {
        GameObject randomProjectile = GetRandomProjectile();
        Instantiate(randomProjectile, attackPoint.position, Quaternion.identity);
    }

    GameObject GetRandomProjectile()
    {
        int randomIndex = Random.Range(0, 3);
        switch (randomIndex)
        {
            case 0:
                return ball;
            case 1:
                return pipe;
            case 2:
                return ring;
            default:
                return ball;
        }
    }
}