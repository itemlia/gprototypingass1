using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class retryButton : MonoBehaviour
{
    public TextMeshProUGUI textComp;

    public Button retry;

    public void Start()
    {
        
        textComp = GameObject.Find("game over").GetComponent<TextMeshProUGUI>();

        gameObject.SetActive(false);

        var btn = retry.GetComponent<Button>();
        btn.onClick.AddListener(retryLevel);
    }
    

    public void retryLevel()
    {
        textComp.text = string.Empty;
        gameObject.SetActive(false);

        GameObject.Find("player").GetComponent<characterController>().health = 100;
        GameObject.Find("player").GetComponent<hitDebris>().pointsCounter = 0;
        
    }

}
