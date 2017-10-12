using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Image healthBar;

    int startingHealth;
    float startingHealthBarSize;
    PlayerHealth health;

	void Start () {
        health = Player.player.GetComponent<PlayerHealth>();
        startingHealth = health.health;
        startingHealthBarSize = healthBar.rectTransform.sizeDelta.x;
	}
	
	void Update () {
        float f = 0;
        if (health)
        {
            f = (float)health.health / startingHealth;
        }
        healthBar.rectTransform.sizeDelta = new Vector2(startingHealthBarSize * f, healthBar.rectTransform.sizeDelta.y);
    }
}
