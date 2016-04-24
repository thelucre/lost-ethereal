using UnityEngine;
using System.Collections;

public class AbigailTriggerScript : ActivateBase {

	public AbigailScript Abigail;

	public override void Activate () {
		Settings.canMove = false;
		Abigail.Look();
		Destroy(gameObject);
	}
}
