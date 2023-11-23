using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject ball;
    public GameObject pipe;
    public GameObject ring;
    public Transform attackPoint1;
    public Transform attackPoint2;
    public Transform attackPoint3;
    public float rotationInterval = 3.0f;

    void Start()
    {
        StartCoroutine(ShootRoutine());
    }

    IEnumerator ShootRoutine()
    {
        while (true)
        {
            Shoot(ball, attackPoint1);
            Shoot(pipe, attackPoint2);
            Shoot(ring, attackPoint3);

            yield return new WaitForSeconds(rotationInterval);

            // Rotate the attack points
            attackPoint1.Rotate(Vector3.up * 120.0f);
            attackPoint2.Rotate(Vector3.up * 120.0f);
            attackPoint3.Rotate(Vector3.up * 120.0f);
        }
    }

    void Shoot(GameObject projectileType, Transform attackPoint)
    {
        Instantiate(projectileType, attackPoint.position, attackPoint.rotation);
    }
}