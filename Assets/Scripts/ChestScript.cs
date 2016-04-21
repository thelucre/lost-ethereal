using UnityEngine;
using System.Collections;

public class ChestScript : ActivateBase {

	public Sprite OpenSprite;
	SpriteRenderer sr;
	AudioSource audio;
	GameObject chest;

	void Start() {
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();
		chest = Resources.Load("Key") as GameObject;
	}

	public override void Activate() {	
		sr.sprite = OpenSprite;
		Settings.key = true;
		audio.Play();
		Instantiate(chest);
	}
}
