using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class characterController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rBody;
    private BoxCollider2D boxColl;

    bool move;

    public void controls(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Vector2 dir = ctx.ReadValue<Vector2>();
            move = true;
        } 
        else if (ctx.canceled)
        {
            move = false;
        }

    }



    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
       
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
