﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public float invisibleTime;
    public AudioClip hurtSound;
    public GameObject explosion;

    [HideInInspector]
    public bool invinsible;

    [HideInInspector]
    public float hurtShake;

    float hurtShakeAmplitude;
    float hurtLerp;

    public void Hurt(int amount)
    {
        if (invinsible)
            return;
        
            
        GetComponent<AudioSource>().PlayOneShot(hurtSound);

        hurtShakeAmplitude = 10;
        health -= amount;
        invinsible = true;
        Invoke("StopInvinsible", invisibleTime);
        if (health <= 0)
        {
            Replay();
        }
    }

    void Replay() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void StopInvinsible()
    {
        invinsible = false;
    }

    void Update()
    {
        hurtShake = hurtShakeAmplitude * Mathf.Sin(Time.time * 42.0f);
        hurtShakeAmplitude = Mathf.Max(0, hurtShakeAmplitude - 7.5f * Time.deltaTime);
    }
}
