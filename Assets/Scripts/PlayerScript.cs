using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float Speed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float movex = Input.GetAxisRaw("Horizontal");
		float movey = Input.GetAxisRaw("Vertical");

		transform.Translate(movex*Speed*Time.deltaTime, movey*Speed*Time.deltaTime, 0);
	}
}
