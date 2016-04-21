using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float Speed = 50f;
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
	}

}
