using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public Vector3 rotationAxis = Vector3.forward;

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
