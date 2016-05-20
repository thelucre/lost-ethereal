using UnityEngine;
using System.Collections;

public class AltarSlotScript : ActivateBase {

	public Sprite ActiveSprite;

	public static int ActiveAltars = 0;
	SpriteRenderer sr;
	AudioSource audio;

	void Start() {
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag != "player" || Active) return;
		if(Settings.energy <= 0) return; 

		Active = true;
		Activate();
	}

	public override void Activate () {
		sr.sprite = ActiveSprite;
		audio.Play();

		Settings.energy--;
		ActiveAltars++;

		if(ActiveAltars>= 9) {
			CarolScript carol = GameObject.FindObjectOfType<CarolScript>();
			carol.Begin();
		}
	}
}
