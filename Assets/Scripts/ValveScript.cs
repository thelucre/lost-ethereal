using UnityEngine;
using System.Collections;

public class ValveScript : ActivateBase {

	public Sprite ActiveSprite;
	public SpillwayScript Spillway;

	SpriteRenderer sr;
	Sprite InactiveSprite;

	void Start() {
		Active = true;
		sr = gameObject.GetComponent<SpriteRenderer>();

		InactiveSprite = sr.sprite;
		Invoke("Activate", 0.1f);
	}

	public override void Activate() {
		sr.sprite = ActiveSprite;
		sr.color = new Color(255,255,255,1f);
		Spillway.Deactivate();
	}

	public override void Deactivate() {
		Spillway.Activate();
		sr.color = new Color(255,255,255,0.3f);
		sr.sprite = InactiveSprite;
	}

	public void Toggle() {
		Active = !Active;
		if(Active) Activate();
		else Deactivate();
	}
}
