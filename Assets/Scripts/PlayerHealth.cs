using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public float invisibleTime;
    public AudioClip hurtSound;

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

        hurtShakeAmplitude = amount * 2;
        health -= amount;
        invinsible = true;
        Invoke("StopInvinsible", invisibleTime);
    }

    void StopInvinsible()
    {
        invinsible = false;
    }

    void Update()
    {
        hurtShake = hurtShakeAmplitude * Mathf.Sin(Time.time * 42.0f);
        hurtShakeAmplitude = Mathf.Max(0, hurtShakeAmplitude - 6.5f * Time.deltaTime);
    }
}
