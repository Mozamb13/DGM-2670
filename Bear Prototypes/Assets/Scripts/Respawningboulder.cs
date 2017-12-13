using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawningboulder : MonoBehaviour {
public Transform target;
	public Transform respawnPoint;
	public Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
		
	 }
	void OnTriggerEnter(Collider hit)
	{
		if(hit.gameObject.tag == "Ground"){
			StartCoroutine("Respawn",0f);
		}
	}
	IEnumerator Respawn (float spawnDelay)
	{
		yield return new WaitForSeconds(spawnDelay);
		target.transform.position = respawnPoint.transform.position;
	}
}
