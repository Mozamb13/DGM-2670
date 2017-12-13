using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour {
	public GameObject PauseUI;
	// Use this for initialization
	public void Resumebutton () {
		Continue();
	}
	void Continue () {
		PauseUI.SetActive(false);
		print("resume");
	
	}
}

