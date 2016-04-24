using UnityEngine;
using System.Collections;

public class ActivateBase : ObjectBaseScript {

	public bool 
	Active = false,
	OneTime = true,
	DeactivateOnExit = false,
	Toggle = false,
	HasBeenActivated = false;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag != "player") return;

		if(OneTime) {
			if(HasBeenActivated) return;
			HasBeenActivated = true;
			Active = true;
			Activate();
		}

		if(Toggle) { 
			Active = !Active; 
			if(Active) Activate(); else Deactivate();
		}

	}


	void OnTriggerExit2D(Collider2D other) {
		if(!ActiveInScene) return;
		if(other.gameObject.tag != "player") return;

		if(DeactivateOnExit) { 
			Active = false; 
			Deactivate();
		}
	}

	public virtual void Activate() {}
	public virtual void Deactivate() {}
}
