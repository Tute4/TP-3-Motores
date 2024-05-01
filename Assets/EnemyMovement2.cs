using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float speed = 3f;
    public float moveDistance = 5f;

    private float startY;
    private bool movingUp = true;
    public Transform spawnPoint;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Mathf.Abs(transform.position.y - startY) > moveDistance)
        {
            movingUp = !movingUp;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            collision.gameObject.transform.position = spawnPoint.position; 
        }
    }
}
