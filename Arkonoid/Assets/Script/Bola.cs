using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed;
    int directionX = 1;
    int directionY = 1;


    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed * directionX, speed * directionY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        {
            directionX *= -1;
        }
        if (!collision.gameObject.CompareTag("Parede"))
        {
            directionY *= -1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Tijolo"))
        {
            directionX *= -1;
            Destroy(collision.gameObject);//Esse destroi o inimigo
        }
    }

}