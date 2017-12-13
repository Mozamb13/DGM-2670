using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
	public GameObject PauseUI;
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			PauseUI.SetActive(true);
			print("pause");
		}
	}
}
