using UnityEngine;
using System.Collections;

public enum BGM {
	NULL = -1,
	MAIN,
	CAVE,
	DESERT,
	ENDING
}

public class MusicManagerScript : MonoBehaviour {

	public AudioClip[] Music;

	AudioSource audio;
	AudioClip MusicTarget;
	bool fadingOut = false;
	float Speed = 0.02f;

	// Use this for initialization
	void Start () {
		audio = gameObject.GetComponent<AudioSource>();
		audio.volume = 0;
		Play(BGM.MAIN);
	}

	void Update() {
		float volume = audio.volume; 

		if(fadingOut) {
			volume -= Speed;

			if(volume <= 0 && MusicTarget) {
				audio.clip = MusicTarget;
				fadingOut = false;
				audio.Play();
			}
		} else {
			volume += Speed;
		}

		// limit audio volume to 0.0 - 1.0
		audio.volume = Mathf.Clamp01(volume);
	}

	public void Play(BGM index) {
		MusicTarget = Music[(int)index];
		fadingOut = true;
	}

}
