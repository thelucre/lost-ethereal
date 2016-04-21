using UnityEngine;
using System.Collections;

public class ChestScript : ActivateBase {

	public Sprite OpenSprite;
	SpriteRenderer sr;
	AudioSource audio;

	void Start() {
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();
	}

	public override void Activate() {	
		sr.sprite = OpenSprite;
		Settings.key = true;
		audio.Play();
	}
}
