using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceHealth : MonoBehaviour {

    void onTriggerEnter(Collider other)
    {
        HealthBar.health += 30;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
