using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pointCounter : MonoBehaviour
{
    public TextMeshProUGUI textComp;

    public float pointsCounter;

    void Update()
    {
        pointsCounter = GameObject.Find("player").GetComponent<hitDebris>().pointsCounter;

        string pointBox = pointsCounter.ToString();
        textComp.text = pointBox;
    }
}
