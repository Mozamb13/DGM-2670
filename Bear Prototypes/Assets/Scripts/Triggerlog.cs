using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerlog : MonoBehaviour {
	
	public GameObject Beehive;
	public Transform spawn;
	public Transform target;

	void OnTriggerEnter(Collider other)
	{
		Beehive.SetActive(false);
		target.transform.position = spawn.transform.position;
	
	}
	
}
