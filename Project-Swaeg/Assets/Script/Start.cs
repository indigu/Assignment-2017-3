using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {
    public void StartGame(string name)
    {
        Application.LoadLevel(name);
    }
	
}
