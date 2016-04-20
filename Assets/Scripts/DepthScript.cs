using UnityEngine;
using System.Collections;

public class DepthScript : MonoBehaviour {

	public int Offset = 0;
	public bool OneTime = true;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		if(OneTime) SetOrder();
	}
	
	// Update is called once per frame
	void Update () {
		if(!OneTime) SetOrder();
	}

	void SetOrder() {
		sr.sortingOrder = (int)Mathf.Ceil(-transform.position.y)+Offset;
	}
}
