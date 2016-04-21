using UnityEngine;
using System.Collections;

public class ObjectBaseScript : MonoBehaviour {

	public bool ActiveInScene = false;

	void OnBecameVisible() {
		ActiveInScene = true;
	}

	void OnBecameInvisible() {
		ActiveInScene = false;
	}
}
