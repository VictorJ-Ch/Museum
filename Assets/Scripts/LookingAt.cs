using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player != null)
        {
            transform.LookAt(player);
        }
        else
        {
            Debug.LogWarning("No se ha asignado el jugador al script LookAtPlayer.");
        }
    }
}
