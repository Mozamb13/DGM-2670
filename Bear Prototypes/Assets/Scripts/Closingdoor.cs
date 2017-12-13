using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closingdoor : MonoBehaviour {
	public Transform target;
	public Transform spawn;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
		target.transform.position = spawn.transform.position;
		}
	}
}
