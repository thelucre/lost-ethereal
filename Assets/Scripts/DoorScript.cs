using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	bool Open = false;
	Animator anim;
	Collider2D collider;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		collider = gameObject.GetComponent<Collider2D>();
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(!Settings.key) return;
		if(other.transform.tag != "player" || Open) return; 

		Open = true;
		anim.SetTrigger("open");
		Settings.canMove = false;
	}

	void RemoveCollider() {
		collider.enabled = false;
		Settings.canMove = true;
	}
}
