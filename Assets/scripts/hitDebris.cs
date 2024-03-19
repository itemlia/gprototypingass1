using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.InputSystem;

public class hitDebris : MonoBehaviour
{

    private GameObject fallingDebris;

    private bool debris;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("debris"))
        {
            debris = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("debris"))
        {
            debris = false;
            fallingDebris = collision.gameObject;
        }
    }

    public void hitFallingDebris(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            if (debris == true)
            {
                Destroy(fallingDebris);
            }
        }
    }
}
