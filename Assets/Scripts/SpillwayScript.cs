using UnityEngine;
using System.Collections;

public class SpillwayScript : ActivateBase {

	public SpillwayScript[] ReliesOn;
	public bool Open = false;
	public int Number = 0;

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		Deactivate();
	}

	void Update() {
		Check();

		if(Number == 5 && sr.enabled) 
			Debug.Log("FINISHED!");
	}

	public void Check() {
		Active = CanActivate() && Open;
		sr.enabled = Active;
	}


	public override void Activate() {
		Open = true;
	}

	public override void Deactivate() {
		Open = false;
	}
		

	bool CanActivate() {
		if(ReliesOn.Length<=0) return true;

		foreach(SpillwayScript spillway in ReliesOn) {
			if(!spillway.Open || !spillway.Active) return false;
		}
		return true;
	}
}
