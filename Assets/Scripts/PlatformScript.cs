using UnityEngine;
using System.Collections;

public class PlatformScript : ObjectBaseScript {

	Transform player;

	public float 
	distx = 5, 
	disty = 4,
	range = 5;

	float startx, starty,
	alpha = 0,
	speed = 30f;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		startx = transform.position.x;
		starty = transform.position.y;
		player = GameObject.FindGameObjectWithTag("player").transform;
		sr = gameObject.GetComponent<SpriteRenderer>();

		transform.Translate(0,range,0);

		sr.color = new Color(255,255,255,0);
		transform.Translate(0,-range,0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!ActiveInScene) return;

		Vector3 pos = transform.position;

		if(Mathf.Abs(startx - player.position.x) < distx && 
			Mathf.Abs(starty - player.position.y) < disty) {

			// Moving Up
			pos.y += speed*Time.deltaTime;
			alpha += speed/range*Time.deltaTime;
		} 
		else {
			// moving down 
			pos.y -= speed*Time.deltaTime;
			alpha -= speed/range*Time.deltaTime;
		}

		pos.y = Mathf.Clamp(pos.y, starty-range, starty);
		alpha = Mathf.Clamp01(alpha);

		sr.color = new Color(255,255,255,alpha);
		transform.position = pos;
	}
}
