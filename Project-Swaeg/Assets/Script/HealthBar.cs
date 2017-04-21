using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    // Use this for initialization

    public static int health = 100;
    public GameObject player;
    public Slider healthBar;


    void Start ()
    {
        InvokeRepeating("ReduceHealth", 1, 1);
    }

	void ReduceHealth()
    {
        health = health - 10;
        healthBar.value = health;
    }

	// Update is called once per frame
	void Update () {
		
	}
}

