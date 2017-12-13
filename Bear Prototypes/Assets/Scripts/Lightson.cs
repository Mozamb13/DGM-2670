using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightson : MonoBehaviour {

	public Light sunLight;


	void Start()
	{
		sunLight = GetComponent<Light>();
	}
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			sunLight.intensity = 2f;
			print("lights on");

		}
	}	

}
