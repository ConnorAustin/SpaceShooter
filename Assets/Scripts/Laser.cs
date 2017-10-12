using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    public float speed;
    public GameObject particle;
    public GameObject laserDeathSound;

	void Start () {
    }

    void OnCollisionEnter(Collision collision)
    {
        Die();
    }

    void Die()
    {
        for (int i = 0; i < 5; i++)
        {
            var p = GameObject.Instantiate(particle);
            p.transform.position = transform.position;
        }
        var lds = GameObject.Instantiate(laserDeathSound);
        lds.transform.position = transform.position;

        Destroy(gameObject);
    }

    void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;
	}
}
