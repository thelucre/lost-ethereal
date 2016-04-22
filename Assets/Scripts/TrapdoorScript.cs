using UnityEngine;
using System.Collections;

public class TrapdoorScript : ActivateBase {

	public Sprite OpenSprite;
	SpriteRenderer sr;
	AudioSource audio;

	void Start() {
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();
	}

	public override void Activate() {	
		sr.sprite = OpenSprite;
		audio.Play();
		Settings.canMove = false;
		Invoke("CanMove", 1f);
	}

	void CanMove() {
		Settings.canMove = true;
	}
}
