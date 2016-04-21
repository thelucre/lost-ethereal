using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	public Vector2 target;
	GameObject Screenwipe;
	Transform player;

	void Start() {
		Screenwipe = Resources.Load("Screenwipe") as GameObject;
	}


	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag != "player") return;

		Settings.canMove = false;

		Instantiate(Screenwipe); 
		player = other.transform;

		Invoke("MovePlayer", 1f);
		Invoke("TeleportOver", 1.6f);
	}

	void MovePlayer() {
		if(player == null) return;

		Vector3 pos = player.position;
		pos.x = target.x;
		pos.y = target.y;
		player.position = pos;
	}

	void TeleportOver() {
		Settings.canMove = true;
	}

}
