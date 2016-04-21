using UnityEngine;
using System.Collections;

public class BridgeScript : ActivateBase {

	Animator anim;
	BoxCollider2D collider;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		collider = gameObject.GetComponent<BoxCollider2D>();
	}
	
	public override void Activate() {
		Invoke("Open", 1.4f);
	}

	void Open() {
		anim.SetTrigger("open");
	}

	void Finished() {
		collider.enabled = false;
	}
}
