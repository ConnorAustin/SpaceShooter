using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoi : MonoBehaviour {
    public float amplitude;

    Vector3 startPos;

	void Start () {
        startPos = transform.position;
    }
	
	void Update () {
        float offset = amplitude * Mathf.Sin(Time.time * 2.0f);

        transform.position = startPos + Vector3.up * offset;
	}
}
