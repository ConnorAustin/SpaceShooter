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
        var camPos = transform.position;
        camPos.z = player.position.z - offset;

        transform.position = camPos;
    }
}
