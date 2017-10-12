using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour, Gun
{
    public float fireRate;
    public GameObject laser;
    bool firing;
    Transform muzzle;

    void Start()
    {
        muzzle = transform.Find("Muzzle");
        Fire();
    }

    public void Fire()
    {
        if (!firing)
        {
            firing = true;
            PewPew();
        }
    }

    // Gun interface
    public void StopFire()
    {
        firing = false;
        CancelInvoke("PewPew");
    }

    void PewPew()
    {
        if (!firing)
            return;
        Invoke("PewPew", fireRate);

        var l = GameObject.Instantiate(laser);
        l.transform.position = muzzle.position;
        l.transform.LookAt(muzzle.position + muzzle.forward);
    }
}
