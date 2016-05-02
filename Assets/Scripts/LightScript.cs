using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	SpriteRenderer sr;
	float Speed = 6f;
	public bool Active = false;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		Deactivate();
	}

	public void Activate() {
		sr.enabled = true;
		Active = true;
	}

	public void Deactivate() {
		sr.enabled = false;
		Active = false;
	}

	public void Move(Vector2 direction) {
		Vector3 move = direction;
		move *= (Time.deltaTime * Speed);
		transform.Translate(move);
	}

}
