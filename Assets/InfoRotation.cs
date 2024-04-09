using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Get the current rotation of the object
        Quaternion currentRotation = transform.rotation;

        // Calculate the rotation increment around the Y-axis
        float newYRotation = currentRotation.eulerAngles.y + rotationSpeed * Time.deltaTime;

        // Apply the new rotation
        transform.rotation = Quaternion.Euler(0f, newYRotation, 0f);
    }
}
