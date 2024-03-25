using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class retryButton : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public TextMeshProUGUI textCOmp2;

    public Button retry;

    public Transform playerTransform;

    public void Start()
    {
        
        textComp = GameObject.Find("game over").GetComponent<TextMeshProUGUI>();

        gameObject.SetActive(false);

        var btn = retry.GetComponent<Button>();
        btn.onClick.AddListener(retryLevel);
        playerTransform = GameObject.Find("player").GetComponent<Transform>();
    }
    

    public void retryLevel()
    {
        textComp.text = string.Empty;
        textCOmp2.text = string.Empty;
        gameObject.SetActive(false);

        GameObject.Find("player").GetComponent<characterController>().health = 100;
        GameObject.Find("player").GetComponent<hitDebris>().pointsCounter = 0;

        playerTransform.position = new Vector3(-0.109999999f, 0.478999853f, 0f);

    }

}
