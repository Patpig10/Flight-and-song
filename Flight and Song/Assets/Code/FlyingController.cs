using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingController : MonoBehaviour
{
    public float speed = 5.0f;  // Movement speed
    public float rotationSpeed = 2.0f;  // Rotation speed
    public float ascendDescendSpeed = 3.0f;  // Ascend and Descend speed

    private float pitch = 0.0f;  // Current pitch angle

    void Update()
    {
        // Forward and backward movement
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = transform.forward * vertical + transform.right * horizontal;
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate around the Y-axis (yaw)
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);

        // Rotate around the local X-axis (pitch)
        pitch -= mouseY * rotationSpeed;
        pitch = Mathf.Clamp(pitch, -90.0f, 90.0f);
        Camera.main.transform.localRotation = Quaternion.Euler(pitch, 0.0f, 0.0f);

        // Ascend and Descend
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * ascendDescendSpeed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * ascendDescendSpeed * Time.deltaTime, Space.World);
        }
    }
}