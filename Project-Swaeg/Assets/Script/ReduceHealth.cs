using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceHealth : MonoBehaviour {

    void onTriggerEnter(Enemy other)
    {
        HealthBar.health -= 50;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
