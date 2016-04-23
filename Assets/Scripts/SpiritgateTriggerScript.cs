using UnityEngine;
using System.Collections;

public class SpiritgateTriggerScript : ActivateBase {

	public GameObject SpiritGate;
	public string State = "open";

	void OnTriggerEnter2D(Collider2D other) {
		
		if(other.gameObject.tag != "player") return;

		if(State == "open") { 
			Activate(); 
			State = "closed";
		} else if (State == "closed" && Settings.wand) {
			Deactivate();
			Destroy(gameObject);
		}
	}

	public override void Activate() {
		SpiritGate.SendMessage("Activate");
		Debug.Log(SpiritGate);
	}

	public override void Deactivate() {
		SpiritGate.SendMessage("Deactivate");
	}
}
