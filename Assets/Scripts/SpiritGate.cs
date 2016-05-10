using UnityEngine;
using System.Collections;

public class SpiritGate : ActivateBase {

	public AudioClip GateOpenSound;

	Collider2D collider;
	SpriteRenderer sr;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		collider = gameObject.GetComponent<Collider2D>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();

		collider.enabled = false;
		sr.enabled = false;
	}
	
	public override void Activate() {
		Debug.Log("activating spirit gate");
		collider.enabled = true;
		sr.enabled = true;
		audio.Play();
	}

	public override void Deactivate() {
		collider.enabled = false;
		sr.enabled = false;
		audio.clip = GateOpenSound;
		audio.Play();

		GameObject teleport = GameObject.FindGameObjectWithTag("finalteleport");
		teleport.GetComponent<Collider2D>().enabled = true;
	}
}
