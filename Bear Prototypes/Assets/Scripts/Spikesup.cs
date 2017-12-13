using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikesup : MonoBehaviour {
	public Vector3 moveDoor;
	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(DoorFloat());
	}
	// Update is called once per frame
	IEnumerator DoorFloat () {
		while(moveDoor.y < 0.16f){
			moveDoor.y += 0.2f*Time.deltaTime;
			transform.Translate(moveDoor);
			yield return new WaitForSeconds(0.01f);
	
	}
	}
}
