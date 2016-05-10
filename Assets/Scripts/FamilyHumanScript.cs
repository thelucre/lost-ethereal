using UnityEngine;
using System.Collections;

public class FamilyHumanScript : MonoBehaviour {

	public GameObject ItemPrefab;
	public bool GiveItem = true;

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
				if(GiveItem) Instantiate(ItemPrefab);
				Destroy(gameObject);
			}
		}
	}

	void WaveStarted() {
		if(Triggered || !GiveItem) return;
		Triggered = true;
		Invoke("Fade", 2f);
	}

	void Fade() {
		if(!GiveItem) return;
		Fading = true;
	}
}
