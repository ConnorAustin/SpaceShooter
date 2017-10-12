using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour {
    public int amount;
    public bool hurtBaddies = false;

    void OnCollisionEnter(Collision collision) {
        if (hurtBaddies)
        {
            var enemyHealth = collision.collider.GetComponent<EnemyHealth>();
            if (enemyHealth)
            {
                enemyHealth.Hurt(amount);
            }
        }
        else
        {
            var playerHealth = collision.collider.GetComponent<PlayerHealth>();
            if (playerHealth)
            {
                playerHealth.Hurt(amount);
            }
        }
    }
}
