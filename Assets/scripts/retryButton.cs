using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class retryButton : MonoBehaviour
{
    public float playerHealth;

    public TextMeshProUGUI textComp;

    public void Start()
    {
        playerHealth = GameObject.Find("player").GetComponent<characterController>().health;
        textComp = GameObject.Find("game over").GetComponent<TextMeshProUGUI>();
    }
    

    public void OnMouseDown()
    {
        playerHealth = 100;
        textComp.text = string.Empty;
        gameObject.SetActive(false);
    }

}
