using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class hitDebris : MonoBehaviour
{

    public GameObject fallingDebris;

    public bool debris;

    public float pointsCounter = 0;
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
        if (context.interaction is MultiTapInteraction && debris == true)
        {
            
            pointsCounter = pointsCounter + 1;
            Destroy(fallingDebris);
            Debug.Log("hit");
        }
    }

   
}
