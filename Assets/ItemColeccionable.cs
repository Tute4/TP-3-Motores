using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColeccionable : MonoBehaviour
{
    // Referencia al texto que muestra el número de items recolectados en la interfaz de usuario
    public Text textoContador;

    // Contador de items recolectados
    private static int itemsRecolectados = 0;

    // Número total de items a recolectar
    private static int totalItems = 3;

    // Método llamado cuando este objeto colisiona con otro objeto
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisionó tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Incrementa el contador de items recolectados
            itemsRecolectados++;

            // Actualiza el texto del contador en la interfaz de usuario
            if (textoContador != null)
            {
                textoContador.text = "Items recolectados:" + itemsRecolectados.ToString() + "/" + totalItems.ToString();
            }

            // Desactiva el objeto coleccionable
            gameObject.SetActive(false);
        }
    }
}
