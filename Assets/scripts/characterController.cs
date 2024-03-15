using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rBody;
    private BoxCollider2D boxColl;


    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rBody.velocity = new Vector2(horizontalInput, verticalInput) * speed;

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 10;
            rBody.velocity = new Vector2(rBody.velocity.x, speed);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            speed = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            rBody.gravityScale = 0;
        }
        else
        {
            rBody.gravityScale = 20;
        }
    }


}
