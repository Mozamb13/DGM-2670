using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SendWeaponAttach : MonoBehaviour {

	public static Action<Transform> SendAttachPoint;

	// Use this for initialization
	void Awake () {
		SendAttachPoint(transform);

	}
	
}
