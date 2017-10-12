using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {
    public GameObject particle;
    public float spawnDelay;
    public float thrust;
	
	void Start () {
        Spawn();
	}

    void Spawn()
    {
        Invoke("Spawn", spawnDelay);
        var p = GameObject.Instantiate(particle);
        p.transform.position = transform.position;

        p.GetComponent<Rigidbody>().AddForce(transform.forward * thrust);
    }
}
