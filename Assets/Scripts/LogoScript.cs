using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LogoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("StartGame", 4f);
	}
	
	void StartGame() {
		SceneManager.LoadScene("Game");
	}
}
