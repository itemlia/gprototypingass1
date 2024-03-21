using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthCounter : MonoBehaviour
{

    public TextMeshProUGUI textComp;

    public float playerHealth;

    void Update()
    {
        playerHealth = GameObject.Find("player").GetComponent<characterController>().health;

        string healthInBox = playerHealth.ToString();
        textComp.text = healthInBox;
    }

   
}
