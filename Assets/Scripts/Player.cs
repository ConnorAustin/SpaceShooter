using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player player;

    public float speed;
    public float targetSpeed;
    public float maxTargetSpeed;
    public float maxTargetDistance;

    Vector3 targetVelocity;

    Vector3 target;
    Gun gun;
    Rigidbody rigidBody;
    PlayerHealth health;

    void Awake()
    {
        player = this;
    }

    void Start()
    {
        gun = (Gun)GetComponent<BasicGun>();
        rigidBody = GetComponent<Rigidbody>();
        health = GetComponent<PlayerHealth>();
    }

    float towardsZero(float x, float step) {
        if (x > 0)
        {
            return Mathf.Max(x - step, 0);
        }
        if (x < 0)
        {
            return Mathf.Min(x + step, 0);
        }
        return 0;
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        rigidBody.velocity = Vector3.zero;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (Mathf.Abs(h) < 0.1f && Mathf.Abs(v) < 0.1f)
        {
            target.x = towardsZero(target.x, 1.0f * Time.deltaTime);
            target.y = towardsZero(target.y, 1.0f * Time.deltaTime);
            targetVelocity = Vector3.Lerp(targetVelocity, Vector3.zero, 0.2f);
        }
        else
        {
            targetVelocity.x += h * targetSpeed * Time.deltaTime;
            targetVelocity.y += v * targetSpeed * Time.deltaTime;

            target += targetVelocity * Time.deltaTime;
        }
        targetVelocity = Vector3.ClampMagnitude(targetVelocity, maxTargetSpeed);

        if(Input.GetKey(KeyCode.Space))
        {
            gun.Fire();
        }
        else
        {
            gun.StopFire();
        }

        target = Vector3.ClampMagnitude(target, maxTargetDistance);
        transform.LookAt(target + transform.position + Vector3.forward);
        transform.Rotate(Vector3.forward * (targetVelocity.x * 20 + health.hurtShake));
    }
}
