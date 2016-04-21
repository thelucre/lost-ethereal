using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	public static bool 
	debug, canMove,
	key, ring, gear, wand;

	public static int 
	energy;

	public static void Init() {
		
		// GAME SETTINGS 
		Settings.debug = true;
		Settings.canMove = true;

		// ADVENTURE DATA 
		Settings.energy = 0;
		Settings.key = true;
		Settings.ring = false;
		Settings.gear = true;
		Settings.wand = false;
	}

}
