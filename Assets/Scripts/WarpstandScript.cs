using UnityEngine;
using System.Collections;

public class WarpstandScript : ActivateBase {

	public GameObject Teleport;

	Animator anim;
	Collider2D collider;

	void Start() {
		anim = gameObject.GetComponent<Animator>();
		collider = gameObject.GetComponent<Collider2D>();
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(!Settings.ring) return;
		if(other.transform.tag != "player") return; 

		Activate();
	}

	public override void Activate() {
		Settings.canMove = false; 
		Invoke("CanMove", 0.5f);

		WarpstandScript[] ws = GameObject.FindObjectsOfType<WarpstandScript>();

		foreach(WarpstandScript w in ws) {
			w.Trigger();
		}
	}

	void CanMove() {
		Settings.canMove = true;
	}

	public void Trigger() {
		HasBeenActivated = true;
		collider.enabled = false;
		anim.SetTrigger("active");
		if(Teleport) {
			Teleport.SetActive(true);
		}
	}
}
