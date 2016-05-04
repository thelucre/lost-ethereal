using UnityEngine;
using System.Collections;

public class WindmillSwitchScript : ActivateBase {

	public Sprite ActiveSprite;
	public GameObject Windmill, Bridge;

	SpriteRenderer sr;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		audio = gameObject.GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(!Settings.gear) return;
		if(other.gameObject.tag != "player") return; 

		Activate();
	}
	
	public override void Activate() {
		sr.sprite = ActiveSprite;
		Windmill.SendMessage("Activate");
		Bridge.SendMessage("Activate");
		audio.Play();
	}
}
