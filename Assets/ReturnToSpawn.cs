using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToSpawn : MonoBehaviour
{
    public Transform spawnPoint; // Referencia al punto de spawn

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el jugador ha colisionado con el plano de muerte
        if (collision.gameObject.CompareTag("Player"))
        {
            // Devolver al jugador al punto de spawn
            collision.gameObject.transform.position = spawnPoint.position;
        }
    }
}