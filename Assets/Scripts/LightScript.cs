using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		Deactivate();
	}

	public void Activate() {
		sr.enabled = true;
	}

	public void Deactivate() {
		sr.enabled = false;
	}

}
