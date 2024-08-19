using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);

    }

    private void Update()
    {

        Vector2 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
        if (screenPosition.x < 0 || screenPosition.x > 1 || screenPosition.y < 0 || screenPosition.y > 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {

            Vector2 reflectDir = Vector2.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectDir.normalized * speed;
        }
    }
}
