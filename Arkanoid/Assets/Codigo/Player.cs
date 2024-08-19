using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f; 
    public float screenLimit = 8f; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    private void Update()
    {
       
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

       
        float clampedX = Mathf.Clamp(transform.position.x, -screenLimit, screenLimit);
        transform.position = new Vector2(clampedX, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Rigidbody2D bulletRb = collision.gameObject.GetComponent<Rigidbody2D>();

           
            Vector2 contactPoint = collision.contacts[0].point;
            Vector2 center = new Vector2(transform.position.x, transform.position.y);
            float difference = contactPoint.x - center.x;

          
            Vector2 reflectDir = new Vector2(difference, bulletRb.velocity.y).normalized;
            bulletRb.velocity = reflectDir * bulletRb.velocity.magnitude;
        }
    }
}