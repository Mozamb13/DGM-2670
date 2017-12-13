using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbox : MonoBehaviour {
	
	public Renderer rend;
	public Transform target;
	
	void OnTriggerEnter(Collider other)
	{
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		
	}
}
