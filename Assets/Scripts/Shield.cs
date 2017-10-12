using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {
    public float flashSpeed;
    public Color col1;
    public Color col2;

    Material[] shieldMats;
    float sinePos = 0;
    GameObject shieldObject;
    PlayerHealth health;

	void Start () {
        health = GetComponent<PlayerHealth>();

        var shield = transform.Find("shield");
        shieldObject = shield.gameObject;
        
        shieldMats = new Material[shield.childCount];
        for(int i = 0; i < shield.childCount; i++)
        {
            shieldMats[i] = shield.GetChild(i).GetComponent<Renderer>().material;
        }
    }

	void Update () {
        shieldObject.SetActive(health.invinsible);

        sinePos += flashSpeed * Time.deltaTime;
        Color newCol = Color.Lerp(col1, col2, (Mathf.Sin(sinePos) + 1.0f) / 2.0f);
        foreach (var m in shieldMats)
        {
            m.color = newCol;
        }
	}
}
