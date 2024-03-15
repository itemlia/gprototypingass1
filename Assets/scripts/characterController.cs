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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("rock"))
        {
            collided = false;
        }
    }

    public void onMove(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();

    }

    public void spaceBar(InputAction.CallbackContext context)
    {
        if (context.interaction is HoldInteraction)
        {
           
            if (collided == true)
            {
                Debug.Log("test");
                value = context.ReadValue<Vector2>();

            }
        }
    }


    private void Update()
    {
        transform.Translate(value * (speed * Time.deltaTime));
        
    }

    


}
