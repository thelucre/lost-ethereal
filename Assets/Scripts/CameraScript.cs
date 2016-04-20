using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Target) {
			transform.position = new Vector3(
				Mathf.Floor(Target.position.x/64)*64+32,
				Mathf.Floor(Target.position.y/64)*64+32,
				-10
			);
		}
	}
}
