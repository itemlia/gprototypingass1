using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class youWon : MonoBehaviour
{
    public TextMeshProUGUI textComp;

    public Button button;

    public string youWonText;

    public Transform playerTransform;
    public Transform rockTransform;

    public void Start()
    {
        textComp.text = string.Empty;
    }

    public void Update()
    {
        playerTransform = GameObject.Find("player").GetComponent<Transform>();
        rockTransform = GameObject.Find("rock").GetComponent<Transform>();

        if (playerTransform.position.y >= rockTransform.position.y)
        {
            button.gameObject.SetActive(true);
            textComp.text = youWonText;
        }   
    }
}
