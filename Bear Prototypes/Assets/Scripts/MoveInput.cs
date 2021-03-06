﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

	public float runTime = 0.01f;
	public static Action<float> KeyAction;
	public static Action JumpAction;
	public bool OnPlay = true;
	


	void Start () 
	{
			StartCoroutine(RunInput());
	}
	IEnumerator RunInput(){
		while (OnPlay){
		if(Input.GetKeyDown(KeyCode.Space))
		{
			JumpAction();
			
		}
		if(KeyAction != null)
		{
			KeyAction(Input.GetAxis("Horizontal"));
			
		}
		yield return new WaitForSeconds (runTime);
		}
	}
}
