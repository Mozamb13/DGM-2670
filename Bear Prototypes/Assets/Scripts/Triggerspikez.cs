using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerspikez : MonoBehaviour {
	public Vector3 moveDoor;
	public Renderer rend;
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		StartCoroutine(DoorFloat());
		}
		
	}
	// Update is called once per frame
	IEnumerator DoorFloat () {
		while(moveDoor.y < 0.2f){
			moveDoor.y += 0.2f*Time.deltaTime;
			transform.Translate(moveDoor);
			yield return new WaitForSeconds(0.01f);
	
	}
	}
}
