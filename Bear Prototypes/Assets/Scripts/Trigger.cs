using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public GameObject Beehive;
	public GameObject target;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			Beehive.SetActive(false);
			target.SetActive(false);
		}
	}
	
	
}
