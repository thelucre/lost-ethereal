using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {

	Transform player;

	float startx, starty,
	alpha = 0,
	speed = 0.8f,
	range = 5;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		startx = transform.position.x;
		starty = transform.position.y;
		player = GameObject.FindGameObjectWithTag("player").transform;
		sr = gameObject.GetComponent<SpriteRenderer>();

		transform.Translate(0,range,0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		Debug.Log(Mathf.Abs(startx - player.position.x));
		Debug.Log(Mathf.Abs(starty - player.position.y));

		if(Mathf.Abs(startx - player.position.x) < 5 && 
			Mathf.Abs(starty - player.position.y) < 4) {

			// Moving Up
			pos.y += speed;
			alpha += speed/range;

		} 
		else {
			// moving down 
			pos.y -= speed;
			alpha -= speed/range;
		}

		pos.y = Mathf.Clamp(pos.y, starty-range, starty);
		alpha = Mathf.Clamp01(alpha);

		sr.color = new Color(255,255,255,alpha);
		transform.position = pos;
	}
}
