using UnityEngine;
using System.Collections;

public class AbigailScript : MonoBehaviour {

	public Animator Arm;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	

	public void Look() {
		anim.SetTrigger("look");
		Arm.SetTrigger("look");
	}

	public void DoneLooking() {
		Settings.canMove = true;
	}

	public void Finished() {
		Settings.canMove = false;
		anim.SetTrigger("drink");
	}

	public void FinalLook() {

	}

	public void Flash() {
		Arm.SetTrigger("flash");
	}
}
