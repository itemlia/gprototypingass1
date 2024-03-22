using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class characterController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rBody;
    private CircleCollider2D circColl;

    private bool collided;
    public float health = 100;
    public float points = 0;

    private Vector3 value;

    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        circColl = GetComponent<CircleCollider2D>();
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            collided = true;
            rBody.gravityScale = 0;
        } 
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            collided = false;
            rBody.gravityScale = 1;
        }
       
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") && collided == false)
        {
            if (gameObject.CompareTag("low"))
            {
                health = health - 10;
            }
            else if (gameObject.CompareTag("medium"))
            {
                health = health - 15;
            }
            else if (gameObject.CompareTag("high"))
            {
                health = health - 20;
            }
            else if (gameObject.CompareTag("very high"))
            {
                health = health - 25; 
            }
        }
    }

    public void onMove(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();
    }

    public void climbFunc(InputAction.CallbackContext context)
    {
        if (context.interaction is HoldInteraction)
        {
            if (collided == true)
            {
                value = context.ReadValue<Vector2>();
            }

            if (gameObject.transform.position.y <= 5f)
            {
                gameObject.tag = "low";
            }
            else if (gameObject.transform.position.y <= 10f && gameObject.transform.position.y > 5f)
            {
                gameObject.tag = "medium";
            }
            else if (gameObject.transform.position.y <= 15f && gameObject.transform.position.y > 10f)
            {
                gameObject.tag = "high";
            }
            else if (gameObject.transform.position.y <= 20f && gameObject.transform.position.y > 15f)
            {
                gameObject.tag = "very high";
            }
        }
    }

  

    private void Update()
    {
        transform.Translate(value * (speed * Time.deltaTime));

     
    }

    


}
