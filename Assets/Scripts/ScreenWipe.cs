using UnityEngine;
using System.Collections;

public class ScreenWipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Scren wipe is always centered on camera
		Vector3 pos = Camera.main.transform.position;
		pos.z = -5;
		transform.position = pos;
	}

	void Kill() {
		Destroy(gameObject);
	}
}
