    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    public TextMeshProUGUI textComp;

    public Button button;

    public string gameOverText;

    public float playerHealth;

    public void Start()
    {
        textComp.text = string.Empty;
        button = GameObject.FindWithTag("button").GetComponent<Button>();

    }

    public void Update()
    {
        playerHealth = GameObject.Find("player").GetComponent<characterController>().health;

        if (playerHealth <= 0)
        {
            button.gameObject.SetActive(true);
            textComp.text = gameOverText;
        }
    }
}
