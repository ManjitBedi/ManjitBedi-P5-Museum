using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanels : MonoBehaviour {


  	public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowPanels () {

		if (cam == null) {
		cam = Camera.main;
		}

		if (cam != null) {
			// Tie this to the camera, and do not keep the local orientation.
			transform.SetParent(cam.GetComponent<Transform>(), true);
		}
	}

	public void HidePanels () {


	}
}
