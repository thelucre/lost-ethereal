using UnityEngine;
using System.Collections;

public class DoorScript : ActivateBase {

	bool Open = false;
	Animator anim;
	Collider2D collider;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		collider = gameObject.GetComponent<Collider2D>();
		audio = gameObject.GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(!Settings.key) return;
		if(other.transform.tag != "player" || Open) return; 

		Activate();
	}

	public override void Activate() {
		Open = true;
		anim.SetTrigger("open");
		Settings.canMove = false;
		audio.Play();
	}

	void RemoveCollider() {
		collider.enabled = false;
		Settings.canMove = true;
	}
}
