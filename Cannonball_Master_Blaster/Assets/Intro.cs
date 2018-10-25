using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	// Use this for initialization
	public void OnStartButtonClick () {
        SceneManager.LoadScene("Game");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
