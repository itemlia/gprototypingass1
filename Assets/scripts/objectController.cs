using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class objectController : MonoBehaviour
{
    private Transform tRock;
    private Transform tPlayer;

    private bool condition;

    public float timer;

    public GameObject debris;

    private void Update()
    {
        tRock = GameObject.Find("rock").GetComponent<Transform>();
        tPlayer = GameObject.Find("player").GetComponent<Transform>();

        while (tPlayer.position.y != tRock.position.y)
        {
            StartCoroutine(dropTimer());

        }

    }


    IEnumerator dropTimer()
    {
        yield return new WaitForSeconds(timer);
        Instantiate(debris, new Vector3(tRock.position.x, tRock.position.y, 0f), Quaternion.identity);
        
    }

    //tPlayer.position.y != tRock.position.y

}
