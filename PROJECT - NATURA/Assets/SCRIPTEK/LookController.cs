using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Mouse sensitivity
    public bool clampVerticalRotation = true; // Clamp vertical rotation to prevent flipping

    private float rotationX = 0.0f;

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the player horizontally based on mouse X input
        transform.Rotate(Vector3.up * mouseX * sensitivity);

        // Rotate the camera vertically based on mouse Y input
        rotationX -= mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Clamp the vertical rotation

        // Apply the rotations to the camera
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}