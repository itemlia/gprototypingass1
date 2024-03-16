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

    private GameObject fallingDebris;

    private bool collided;
    private bool debris;

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
        else if (collision.CompareTag("debris"))
        {
            debris = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            collided = false;
            rBody.gravityScale = 1;
        }
        else if (collision.CompareTag("debris"))
        {
            debris = false;
            fallingDebris = collision.gameObject;
        }
    }

    public void onMove(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();
    }

    public void climbFunc(InputAction.CallbackContext context)
    {
        if (context.interaction is PressInteraction)
        {
            if (collided == true)
            {
                value = context.ReadValue<Vector2>();
            }
        }
    }

    public void hitDebris(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            if (debris == true)
            {
                Destroy(fallingDebris);
            }
        }
    }

    private void Update()
    {
        transform.Translate(value * (speed * Time.deltaTime));
        
    }

    


}
