using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {
    public float when;

	void Start () {
        Invoke("PleaseDie", when);
	}

    void PleaseDie() {
        Destroy(gameObject);
    }
}
