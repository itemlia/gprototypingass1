using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class useShield : MonoBehaviour
{
    public GameObject shield;
    public Rigidbody2D charRbody;


    public bool shieldActive;

    private void Awake()
    {

        charRbody = gameObject.GetComponentInParent<Rigidbody2D>();

    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("rock"))
    //    {
    //        charRbody.gravityScale = 0;
    //    }

    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("rock"))
    //    {
    //        charRbody.gravityScale = 1;
    //    }

    //}
    public void callShield(InputAction.CallbackContext context)
    {
        if (context.interaction is PressInteraction)
        {
            if (shieldActive == false)
            {
                shield.SetActive(true);
                shieldActive = true;
            }
            else if (shieldActive == true)
            {
                shield.SetActive(false);
                shieldActive = false;
            }

        }
    }
}


