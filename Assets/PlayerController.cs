using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento vertical
    public float jumpForce = 10f; // Fuerza de salto
    private Rigidbody rb;
    private bool isGrounded; // Indica si el jugador está en el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento vertical y horizontal
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0f, moveVertical, moveHorizontal) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el jugador está en el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}

