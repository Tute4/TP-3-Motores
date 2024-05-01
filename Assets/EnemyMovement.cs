using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    public float moveDistance = 5f;

    private float startZ;
    private bool movingForward = true;
    public Transform spawnPoint;

    void Start()
    {
        startZ = transform.position.z;
    }

    void Update()
    {
        if (movingForward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Mathf.Abs(transform.position.z - startZ) > moveDistance)
        {
            movingForward = !movingForward;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            collision.gameObject.transform.position = spawnPoint.position; // Ejemplo de posición de respawn
        }
    }
}
