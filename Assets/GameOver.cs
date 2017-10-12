using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public GameObject gameOverText;

    void OnTriggerEnter(Collider other)
    {
        Invoke("GO", 12);    
    }

    void GO()
    {
        gameOverText.SetActive(true);
    }
}
