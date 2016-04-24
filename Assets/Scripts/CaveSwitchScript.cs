using UnityEngine;
using System.Collections;

public class CaveSwitchScript : ActivateBase {

	public Sprite ActiveSprite;
	public ValveScript[] Valves;

	Sprite InactiveSprite;
	AudioSource audio;
	SpriteRenderer sr;
	SpillwayScript[] spillways;

	void Start() {
		spillways = FindObjectsOfType<SpillwayScript>();
		audio = gameObject.GetComponent<AudioSource>();
		sr = gameObject.GetComponent<SpriteRenderer>();
		InactiveSprite = sr.sprite;

		Toggle = true;
	}

	public override void Activate() {
		sr.sprite = ActiveSprite;
		audio.Play();
		ToggleValves();
		foreach(SpillwayScript spillway in spillways) {
			spillway.Check();
		}
	}

	public override void Deactivate() {
		audio.Play();
		sr.sprite = InactiveSprite;
		ToggleValves();
		foreach(SpillwayScript spillway in spillways) {
			spillway.Check();
		}
	}

	void ToggleValves() {
		foreach(ValveScript valve in Valves) {
			valve.Toggle();
		}
	}
}
