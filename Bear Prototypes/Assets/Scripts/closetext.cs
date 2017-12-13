using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closetext : MonoBehaviour {
	public GameObject TextUI;
	
	void OnTriggerEnter(Collider other) {
			TextUI.SetActive(false);
			print("pause");
		
	}
}

