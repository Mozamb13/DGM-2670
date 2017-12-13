using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerWater : MonoBehaviour {

	public Transform player;
	public Transform respawnPoint;

	void OnTriggerEnter(Collider hit)
	{
		if(hit.gameObject.tag == "Player"){
			player.transform.position = respawnPoint.transform.position;
			print("Dead, Try again");
		}
	}

}
