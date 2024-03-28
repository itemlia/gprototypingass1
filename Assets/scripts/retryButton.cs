using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class retryButton : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public TextMeshProUGUI textCOmp2;

    public Button retry;

    public Transform playerTransform;

    public objectController oC;

    public void Start()
    {
        textComp = GameObject.Find("game over").GetComponent<TextMeshProUGUI>();
        playerTransform = GameObject.Find("player").GetComponent<Transform>();

        gameObject.SetActive(false);

        var btn = retry.GetComponent<Button>();
        btn.onClick.AddListener(retryLevel);
        
    }
    

    public void retryLevel()
    {
        
        gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        

    }

}
