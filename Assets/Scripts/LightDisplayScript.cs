using UnityEngine;
using System.Collections;

public class LightDisplayScript : MonoBehaviour {

	public bool Show = false;
	public Transform[] Targets;

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log(other.gameObject.tag);
		if(other.gameObject.tag != "player") return; 

		foreach(Transform target in Targets) {
			if(!target) continue;
			target.gameObject.SetActive(Show);
		}
	}
}
