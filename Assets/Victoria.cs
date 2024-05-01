using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Victoria : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            
            int itemsRecolectados = PlayerPrefs.GetInt("ItemsRecolectados", 0) + 1;

            
            PlayerPrefs.SetInt("ItemsRecolectados", itemsRecolectados);

            
            if (itemsRecolectados >= 3)
            {
                
                SceneManager.LoadScene("Pantalla de victoria");
            }
        }
    }
}
