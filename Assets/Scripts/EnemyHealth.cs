using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public GameObject explosion;
    public int health;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void Hurt(int amount)
    {
        health -= amount;
        if (health == 0)
        {
            var exp = GameObject.Instantiate(explosion);
            exp.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
