using UnityEngine;
using System.Collections;

public class WindmillScript : ActivateBase {

	float speed = 10f;

	// Update is called once per frame
	void Update () {
		if(Active) {
			transform.Rotate(0,0,speed*Time.deltaTime);
			if(speed < 140f) speed *= 1.05f;
		}
	}

	public override void Activate() { 
		Active = true;
	}
}
