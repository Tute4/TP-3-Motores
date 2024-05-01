using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColeccionable : MonoBehaviour
{
    
    public Text textoContador;

   
    private static int itemsRecolectados = 0;

    
    private static int totalItems = 3;

    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            itemsRecolectados++;

            
            if (textoContador != null)
            {
                textoContador.text = "Items recolectados:" + itemsRecolectados.ToString() + "/" + totalItems.ToString();
            }

            
            gameObject.SetActive(false);
        }
    }
}
