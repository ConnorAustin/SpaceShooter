using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {
    Transform anchor;
    BasicGun gun;

	void Start () {
        anchor = transform.Find("Anchor");
        gun = GetComponent<BasicGun>();
    }
	
	void Update () {
        anchor.LookAt(Player.player.transform.position);
        if(Vector3.Distance(Player.player.transform.position, transform.position) < 100)
        {
            gun.Fire();
        }
        else
        {
            gun.StopFire();
        }
	}
}
