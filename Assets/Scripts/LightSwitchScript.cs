using UnityEngine;
using System.Collections;

public class LightSwitchScript : ActivateBase {

	public LightScript Light;
	public Sprite ActiveSprite;
	public LightSwitchScript[] others;

	Sprite InactiveSprite;
	SpriteRenderer sr;
	AudioSource audio;
	bool Triggered = false;

	// Use this for initialization
	void Start () {
		audio = gameObject.GetComponent<AudioSource>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		InactiveSprite = sr.sprite;
		Light.SetSwitch(this);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag != "player" || Triggered) return;

		audio.Play();

		Active = !Active;
		if(Active) Activate(); else Deactivate();
	}
	
	public override void Activate() {
		Active = true; 
		sr.sprite = ActiveSprite;
		Light.Activate();

		foreach(LightSwitchScript ls in others) {
			if(!ls.Triggered) ls.Deactivate();
		}
	}

	public override void Deactivate() {
		Active = false; 
		sr.sprite = InactiveSprite;
		Light.Deactivate();
	}

	public void Stop() {
		audio.Play();
		Deactivate();
		Triggered = true; 
	}
}
