﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick () {
		SceneManager.LoadScene("main");
    }
}
