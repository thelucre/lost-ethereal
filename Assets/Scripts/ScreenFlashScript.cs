using UnityEngine;
using System.Collections;

public class ScreenFlashScript : MonoBehaviour {

	public GameObject DestroyTarget, CreateTarget;
	public Vector3 CreateTargetPos;

	Animator anim;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		audio = gameObject.GetComponent<AudioSource>();

		// Scren wipe is always centered on camera
		Vector3 pos = Camera.main.transform.position;
		pos.z = -5;
		transform.position = pos;
		audio.Play();
	}

	void Activate() {
		if(DestroyTarget) Destroy(DestroyTarget);
		if(CreateTarget) Instantiate(CreateTarget, CreateTargetPos, Quaternion.identity);
	}

	void AnimationComplete() {
		Destroy(gameObject);
	}
}
