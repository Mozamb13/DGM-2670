using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {

	public GameObject Treasure;
	public Transform target;
	public Transform spawn;

	void OnTriggerEnter(Collider other)
	{
		Treasure.SetActive(false);
		target.transform.position = spawn.transform.position;
		
	}
}
