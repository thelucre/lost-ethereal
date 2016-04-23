using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float Speed = 18f;
	Rigidbody2D rigidbody;
	Animator anim;

	// Use this for initialization
	void Start () {
		Settings.Init();
		rigidbody = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vel = Vector2.zero;

		if(Settings.canMove) {
			float movex = Input.GetAxisRaw("Horizontal");
			float movey = Input.GetAxisRaw("Vertical");

			vel = new Vector2(movex, movey);
			vel *= Speed;
		}

		rigidbody.velocity = vel;
		anim.SetFloat("speed", vel.magnitude);

		if(Settings.debug) DebugCommands();
	}

	void DebugCommands() {
		// Toggle Key Items 
		if(Input.GetKeyDown(KeyCode.W)) Settings.wand = !Settings.wand;
		if(Input.GetKeyDown(KeyCode.K)) Settings.key = !Settings.key;
		if(Input.GetKeyDown(KeyCode.G)) Settings.gear = !Settings.gear;
		if(Input.GetKeyDown(KeyCode.R)) Settings.ring = !Settings.ring;

		// Increment Energy
		if(Input.GetKeyDown(KeyCode.E)) Settings.energy++;

	}

}
