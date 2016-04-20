using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float Speed = 50f;
	Rigidbody2D rigidbody;
	Animator anim;

	// Use this for initialization
	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float movex = Input.GetAxisRaw("Horizontal");
		float movey = Input.GetAxisRaw("Vertical");

		Vector2 vel = new Vector2(movex, movey);
		vel *= Speed;
		rigidbody.velocity = vel;

		anim.SetFloat("speed", vel.magnitude);
	}
}
