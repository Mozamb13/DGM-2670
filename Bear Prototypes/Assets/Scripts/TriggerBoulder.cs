using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoulder : MonoBehaviour {
	public GameObject Treasure;
	public Rigidbody rb;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
		Treasure.SetActive(false);
		rb = GetComponent<Rigidbody>();
		rb.isKinematic = false;
		}
		
		print("sqwash");
	}
}

