using UnityEngine;
using System.Collections;

public class CodyScript : MonoBehaviour {

	public Animator Arm;
	public Vector3 HumanSpawnPos;

	GameObject screenflash, humanPrefab;
	bool Triggered = false;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
		screenflash = Resources.Load("ScreenFlash") as GameObject;
		humanPrefab = Resources.Load("CodyHuman") as GameObject;
	}


	public void Begin() {
		Settings.canMove = false;
		Debug.Log("Cody Beginning");
	}

	public void Finished() {
		Settings.canMove = false;
		anim.SetTrigger("drink");
	}

	public void Flash() {
		Arm.SetTrigger("flash");
		Invoke("Screenwipe", 1f);
	}

	public void Screenwipe() {
		if(Triggered) return;
		Triggered = true;
		GameObject flash = Instantiate(screenflash);
		ScreenFlashScript sfs = flash.GetComponent<ScreenFlashScript>();
		sfs.DestroyTarget = gameObject; 
		sfs.CreateTarget = humanPrefab;
		sfs.CreateTargetPos = HumanSpawnPos;
	}
}
