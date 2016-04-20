using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	public static bool 
	debug, canMove,
	key, ring, gear, wand;

	public static void Init() {
		
		// GAME SETTINGS 
		Settings.debug = true;
		Settings.canMove = true;

		// ADVENTURE DATA 
		Settings.key = false;
		Settings.ring = false;
		Settings.gear = false;
		Settings.wand = false;
	}
}
