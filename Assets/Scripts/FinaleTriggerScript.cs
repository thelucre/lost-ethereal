using UnityEngine;
using System.Collections;

public class FinaleTriggerScript : ActivateBase {

	public FamilyHumanScript[] Targets;
	public ScreenFadeScript Fader;

	public override void Activate () {
		Settings.canMove = false;
		Invoke("StartWave", 1.5f);
		Invoke("Fade", 7.5f);
	}

	public void StartWave() {
		foreach(FamilyHumanScript fam in Targets) {
			fam.Wave();
		}
	}

	public void Fade() {
		Fader.Activate();
	}
}
