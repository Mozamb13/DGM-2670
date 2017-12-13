using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movinglogger : MonoBehaviour {
	public Vector3 moveIt;
	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(logFloat());
	}
	// Update is called once per frame
	IEnumerator logFloat () {
		while(moveIt.x > -0.1f){
			moveIt.x -= 0.1f*Time.deltaTime;
			transform.Translate(moveIt);
			yield return new WaitForSeconds(0.01f);
	
	}
	}
}