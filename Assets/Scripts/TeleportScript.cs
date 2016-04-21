using UnityEngine;
using System.Collections;

public class TeleportScript : ObjectBaseScript {

	public Vector2 target;
	GameObject Screenwipe;

	void Start() {
		Screenwipe = Resources.Load("Test") as GameObject;
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log(other.gameObject.tag);
		if(!ActiveInScene) return;
		if(other.gameObject.tag != "player") return;

		Settings.canMove = false;
		Instantiate(Screenwipe); 
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log(other.gameObject.tag);
		if(!ActiveInScene) return;
		if(other.gameObject.tag != "player") return;

		Settings.canMove = false;
		Instantiate(Screenwipe); 
	}
}
