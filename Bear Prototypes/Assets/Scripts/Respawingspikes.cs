using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawingspikes : MonoBehaviour {
	public Transform target;
	public Transform respawnPoint;
	
	void OnTriggerEnter(Collider hit)
	{
		if(hit.gameObject.tag == "Ground"){
			StartCoroutine("Respawn",3f);
		}
	}
	IEnumerator Respawn (float spawnDelay)
	{
		yield return new WaitForSeconds(spawnDelay);
		target.transform.position = respawnPoint.transform.position;
	}
}
