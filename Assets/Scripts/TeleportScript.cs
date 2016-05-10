using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	public Vector2 target;
	public BGM Music = BGM.NULL;
	public bool showScreenWipe = true;

	GameObject Screenwipe;
	Transform player;

	void Start() {
		Screenwipe = Resources.Load("Screenwipe") as GameObject;
	}


	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag != "player") return;

		player = other.transform;

		if(!showScreenWipe) {
			MovePlayer();
			return;
		}

		Settings.canMove = false;

		Instantiate(Screenwipe); 


		Invoke("MovePlayer", 1f);
		Invoke("TeleportOver", 1.6f);
	}

	void MovePlayer() {
		if(player == null) return;

		if(Music != BGM.NULL) {
			MusicManagerScript bgm = GameObject.FindObjectOfType<MusicManagerScript>();
			bgm.Play(Music);
		}

		Vector3 pos = player.position;
		pos.x = target.x;
		pos.y = target.y;
		player.position = pos;
	}

	void TeleportOver() {
		Settings.canMove = true;
	}

}
