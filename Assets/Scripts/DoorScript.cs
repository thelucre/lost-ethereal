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
		Debug.Log("DOOR COLLISION");
		if(other.transform.tag != "Player" || Open) return; 

		Open = true;
		anim.SetTrigger("open");
	}

	void RemoveCollider() {
		collider.enabled = false;
	}
}
