using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static int health = 100;
    public GameObject player;
    public Slider healthBar;

    // Use this for initialization
    void Start () {

        InvokeRepeating("ReduceHealth", 1, 1);
        
    }

    public void ReduceHealth()
    {
        healthBar.value = health;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
