using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCrane : MonoBehaviour {
	Animator anims;
	// Use this for initialization
	void Start () {
		anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	 void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
			anims.SetTrigger("Look");
		}
		
	}
}
