using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoi : MonoBehaviour {
    public float amplitude;
    public bool circle;

    Vector3 startPos;
    float randomOffset = 0;

	void Start () {
        startPos = transform.position;
        randomOffset = Random.Range(0.0f, 2 * Mathf.PI);
    }
	
	void Update () {
        if(circle)
        {
            float x = amplitude * Mathf.Cos(Time.time * 2.0f + randomOffset);
            float y = amplitude * Mathf.Sin(Time.time * 2.0f + randomOffset);
            transform.position = startPos + new Vector3(x, y, 0); 
        }
        else
        {
            float offset = amplitude * Mathf.Sin(Time.time * 2.0f + randomOffset);

            transform.position = startPos + Vector3.up * offset;
        }
	}
}
