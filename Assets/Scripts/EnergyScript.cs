using UnityEngine;
using System.Collections;

public class EnergyScript : ActivateBase {

	AudioSource audio;
	SpriteRenderer sr;

	void Start() {
		audio = gameObject.GetComponent<AudioSource>();
		sr = gameObject.GetComponent<SpriteRenderer>();
	}

	public override void Activate() {
		Settings.energy++;
		audio.Play();
		sr.enabled = false;
		Invoke("Kill", 0.7f);
	}
		
	void Kill() {
		Destroy(gameObject);
	}
}
