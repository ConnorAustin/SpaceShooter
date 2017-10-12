using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {
	void Update () {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, 0.05f);
	}
}
