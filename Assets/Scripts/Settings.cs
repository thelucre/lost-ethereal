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
		Settings.debug = false;
		Settings.canMove = true;

		// ADVENTURE DATA 
		Settings.energy = 0;
		Settings.key = false;
		Settings.ring = false;
		Settings.gear = false;
		Settings.wand = false;
			
		// Fixed bug where Cody boss wasn't reset 
		LightScript.GloopKilled = 0;

		// Reset naltar slots on new game
		AltarSlotScript.ActiveAltars = 0;
	}

}
