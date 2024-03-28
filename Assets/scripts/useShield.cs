using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class useShield : MonoBehaviour
{
    public GameObject shield;

    public bool shieldActive;
   
    public void callShield(InputAction.CallbackContext context)
    {
        if (context.interaction is TapInteraction)
        {
            if (shieldActive == false)
            {
                shield.SetActive(true);
                shieldActive = true;
            } 
            
        }
    }

    public void disengageShield(InputAction.CallbackContext context)
    {
        if (context.interaction is SlowTapInteraction)
        {
            if (shieldActive == true)
            {
                shield.SetActive(false);
                shieldActive = false;
            }
        }
    }
}
