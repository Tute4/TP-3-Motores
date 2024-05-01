using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Victoria : MonoBehaviour
{
    // M�todo llamado cuando este objeto colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colision� tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Incrementa el contador de items recolectados
            int itemsRecolectados = PlayerPrefs.GetInt("ItemsRecolectados", 0) + 1;

            // Guarda el n�mero de items recolectados
            PlayerPrefs.SetInt("ItemsRecolectados", itemsRecolectados);

            // Verifica si se han recolectado todos los items
            if (itemsRecolectados >= 3)
            {
                // Carga la escena de victoria
                SceneManager.LoadScene("Pantalla de victoria");
            }
        }
    }
}
