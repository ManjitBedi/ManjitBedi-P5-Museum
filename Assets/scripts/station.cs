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

	public ResonanceAudioSource promptAudio;
    public ResonanceAudioSource contentAudio;

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
                promptAudio.audioSource.Play();
			}
		}
	}

	public void OnExitGaze () {

	}

	public void OnClick () {

		if (promptAudio != null) {
            if (promptAudio.audioSource.isPlaying) {
                promptAudio.audioSource.Stop();
			}
		}

		if (!playing) {
			playing = true;
			stationContent.SetActive (true);
			if (contentAudio != null) {
				contentAudio.audioSource.Play();
			}
		} else {
			playing = false;
				stationContent.SetActive (false);
			if (contentAudio != null) {
				contentAudio.audioSource.Stop();
			}
		}
	}
}
