using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {
	
	public Light sun;


	void Start()
	{
		sun = GetComponent<Light>();
	}
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			sun.intensity = 0f;
			print("lights out");

		}
	}	

}
