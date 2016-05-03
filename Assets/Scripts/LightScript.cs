using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	SpriteRenderer sr;
	LightSwitchScript lightSwitch;
	float Speed = 6f;
	public bool Active = false;

	public static bool CanMove = true;
	public static int GloopKilled = 0;

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
		if(!LightScript.CanMove) return;
		Vector3 move = direction;
		move *= (Time.deltaTime * Speed);
		move = transform.position + move;

		move.x = Mathf.Clamp(move.x,-9f,28f);
		move.y = Mathf.Clamp(move.y,-91.5f,-53.5f);

		transform.position = move;
	}

	public void SetSwitch(LightSwitchScript ls) {
		lightSwitch = ls;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag != "gloop") return;
		SetMove(false);
		other.SendMessage("Kill");

		Invoke("EndLight", 2.5f);
	}

	void SetMove(bool possible = true) {
		LightScript.CanMove = possible;
		Settings.canMove = possible;
	}

	public void EndLight() {
		// stop current switch from working 
		lightSwitch.Stop();

		// reactivate lights moving 
		SetMove(true);

		LightScript.GloopKilled++;

		if(LightScript.GloopKilled >= 3) {
			CodyScript cody = GameObject.FindObjectOfType<CodyScript>();
			if(cody) {
				cody.Begin();
			}
		}

		Destroy(gameObject);
	}

}
