using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class station : MonoBehaviour {

	public float speed = 10f;

	public bool playing = false;
	public bool played = false;

	public bool prompted = false; 

	public GameObject mesh;

	public GameObject stationContent;

	public GvrAudioSource promptAudio;
	public GvrAudioSource contentAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    
    void Update ()
    {
        mesh.transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }




	public void OnEnterGaze () {

		if (!prompted) {
			prompted = true;
			if (promptAudio != null) {
				promptAudio.Play();
			}
		}
	}

	public void OnExitGaze () {

	}

	public void OnClick () {

		if (promptAudio != null) {
			if (promptAudio.isPlaying) {
				promptAudio.Stop();
			}
		}

		if (!playing) {
			playing = true;
			stationContent.SetActive (true);
			if (contentAudio != null) {
				contentAudio.Play();
			}
		} else {
			playing = false;
				stationContent.SetActive (false);
			if (contentAudio != null) {
				contentAudio.Stop();
			}
		}
	}
}
