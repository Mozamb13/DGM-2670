using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {
	public GameObject TextUI;
	
	void OnTriggerEnter(Collider other) {
			TextUI.SetActive(true);
			print("pause");
		
	}
}
