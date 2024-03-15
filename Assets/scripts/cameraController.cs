using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;

    private void Start()
    {
        player = GameObject.Find("player").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = player.position + cameraOffset;
    }
}
