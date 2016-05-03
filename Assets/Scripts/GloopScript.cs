using UnityEngine;
using System.Collections;

public class GloopScript : MonoBehaviour {

	Animator anim;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		audio = gameObject.GetComponent<AudioSource>();
	}
	
	public void Kill() {
		audio.Play();
		anim.SetTrigger("active");
	}

	public void Remove() {
		Destroy(gameObject);
	}
}
