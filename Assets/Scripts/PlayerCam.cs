using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform player;
    public float offset;

    void Start()
    {

    }

    void Update()
    {
        if (player)
        {
            var camPos = transform.position;
            camPos.z = player.position.z - offset;
            camPos.y = player.position.y;
            transform.position = camPos;
            transform.LookAt(player.position);
        }
    }
}
