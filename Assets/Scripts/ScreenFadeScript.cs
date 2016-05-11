using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScreenFadeScript : ActivateBase {

	public SpriteRenderer Credits;

	Animator anim;
	bool credits = false, done = false;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}

	void Update() {

		if(credits && !done) {
			Color c = Credits.color;
			c.a += 0.03f;
			Credits.color = c;

			if(c.a >= 1.0f) {
				done = true;
				Invoke("Restart", 10f);
			}
		}
	}
	
	public override void Activate ()
	{
		anim.SetTrigger("fade");
	}

	public void ShowCredits() {
		credits = true;
	}

	public void Restart() {
		SceneManager.LoadScene("Logo");
	}
}
