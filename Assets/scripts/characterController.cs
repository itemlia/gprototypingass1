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

   

    private Vector3 value;

    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        circColl = GetComponent<CircleCollider2D>();

    }


    public void onMove(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();

    }

    public void spaceBar(InputAction.CallbackContext context)
    {
        if (context.interaction is HoldInteraction)
        {
            Debug.Log(context);

            if (circColl.transform.tag == "rock")
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
