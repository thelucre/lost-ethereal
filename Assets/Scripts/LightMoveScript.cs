using UnityEngine;
using System.Collections;

public class LightMoveScript : ActivateBase {

	public Sprite ActiveSprite;
	public Vector2 Direction;

	Sprite InactiveSprite;
	SpriteRenderer sr;
	AudioSource audio;
	LightScript[] lights;

	// Use this for initialization
	void Start () {
		audio = gameObject.GetComponent<AudioSource>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		lights = GameObject.FindObjectsOfType<LightScript>();
		InactiveSprite = sr.sprite;
	}


	void Update() {
		if(Active) MoveActiveLight();
	}


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag != "player") return;

		audio.Play();

		Active = true;
		Activate();
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.tag != "player") return;

		audio.Play();

		Active = false;
		Deactivate();
	}

	public override void Activate() {
		Active = true; 
		sr.sprite = ActiveSprite;

	}

	public override void Deactivate() {
		Active = false; 
		sr.sprite = InactiveSprite;
	}

	void MoveActiveLight() {
		foreach(LightScript l in lights) {
			if(l.Active) l.Move( Direction );
		}
	}
}