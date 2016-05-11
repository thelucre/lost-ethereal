using UnityEngine;
using System.Collections;

public class FamilyHumanScript : MonoBehaviour {

	public GameObject ItemPrefab;
	public bool BossHuman = true;

	bool Triggered = false;
	bool Fading = false;
	SpriteRenderer sr;
	Animator anim;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		anim = gameObject.GetComponent<Animator>();

		if(!BossHuman) {
			anim.SetTrigger("finale");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Fading) {

			if(!BossHuman) {
				transform.Translate(0,0.2f,0);
			}


			Color c = sr.color;
			c.a -= (BossHuman)? 0.05f : 0.02f;
			sr.color = c;
			if(c.a <= 0f) {
				if(BossHuman) Instantiate(ItemPrefab);
				Destroy(gameObject);
			}
		}
	}

	void WaveStarted() {
		if(Triggered) return;
		Triggered = true;
		Invoke("Fade", 2f);
	}

	void Fade() {
		Fading = true;
	}

	public void Wave() {
		anim.SetTrigger("wave");
	}
}
