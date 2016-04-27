using UnityEngine;
using System.Collections;

public class FamilyHumanScript : MonoBehaviour {

	public GameObject ItemPrefab;

	bool Triggered = false;
	bool Fading = false;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Fading) {
			Color c = sr.color;
			c.a -= 0.05f;
			sr.color = c;
			if(c.a <= 0f) {
				Instantiate(ItemPrefab);
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
}
