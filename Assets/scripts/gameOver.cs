using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public TextMeshProUGUI textComp;

    public string gameOverText;

    public float playerHealth;

    public void Start()
    {
        textComp.text = string.Empty;

    }

    public void Update()
    {
        playerHealth = GameObject.Find("player").GetComponent<characterController>().health;

        if (playerHealth <= 0)
        {
            textComp.text = gameOverText;
        }
    }
}
