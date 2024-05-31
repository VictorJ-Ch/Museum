using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField] private float Velocidadmovimiento;
    [SerializeField] private float VelocidadRotacion;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Transform transformPersonaje;
    [SerializeField] private Camera camaraPersonaje;

    private Vector3 movimiento;
    private float rotacionX;

    private void Update()
    {
        MovimientoDelPersonaje();
        MovimientoCamara();

    }
    void MovimientoDelPersonaje()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        movimiento = transform.right * movX + transform.forward * movZ;
        characterController.SimpleMove(movimiento * Velocidadmovimiento);
    }

    void MovimientoCamara()
    {
        float ratonX = Input.GetAxis("Mouse X") * VelocidadRotacion;
        float ratonY = Input.GetAxis("Mouse Y") * VelocidadRotacion;

        rotacionX -= ratonY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);
        
        camaraPersonaje.transform.localRotation = Quaternion.Euler(rotacionX, 0, 0);
        transformPersonaje.Rotate(Vector3.up * ratonX);
    }

}
