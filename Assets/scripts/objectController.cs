using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class objectController : MonoBehaviour
{
    private Transform tRock;
    private Transform tPlayer;

    public float timer = 2;

    public GameObject debris;

    private void Update()
    {
        tRock = GameObject.Find("rock").GetComponent<Transform>();
        tPlayer = GameObject.Find("player").GetComponent<Transform>();

        debrisLoop();
    }

    private void debrisLoop()
    {
        while (tPlayer.position.y != tRock.position.y)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Instantiate(debris, new Vector3(tRock.position.x, tRock.position.y, 0f), Quaternion.identity);
                timer = 2f;
            }
        }
    }

    
}
