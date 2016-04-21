using UnityEngine;
using System.Collections;

public class ItemDetailScript : MonoBehaviour {

	public string Type = "key";

	Animator anim;
	AudioSource audio;
	bool scalingUp = true, hold = false, wait = true;
	float scaleSpeed = 1f;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		audio = gameObject.GetComponent<AudioSource>();
		anim.SetTrigger("key");

		// Scren wipe is always centered on camera
		Vector3 pos = Camera.main.transform.position;
		pos.z = -5;
		transform.position = pos;

		Invoke("UnWait", 0.3f);
		Settings.canMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(wait) return;

		if(scalingUp) {
			transform.localScale += Vector3.one*Time.deltaTime*scaleSpeed;

			if(transform.localScale.x >= 1) { 
				transform.localScale = Vector3.one;
				scalingUp = false;
				hold = true;
				Invoke("UnHold", 2f);
				audio.Play();
			}
		} 

		if(!hold && !scalingUp) {
			transform.localScale -= Vector3.one*Time.deltaTime*scaleSpeed;

			if(transform.localScale.x <= 0) {
				AddItem();
				Settings.canMove = true;
				Destroy(gameObject);
			}
		}
	}

	void UnHold() {
		hold = false;
	}

	void UnWait() {
		wait = false;
	}

	void AddItem() {
		switch(Type) {
		case "key":
			Settings.key = true;
			break;
		case "ring":
			Settings.ring = true;
			break;
		case "gear":
			Settings.gear = true;
			break;
		case "wand":
			Settings.wand = true;
			break;
		}
	}
}
