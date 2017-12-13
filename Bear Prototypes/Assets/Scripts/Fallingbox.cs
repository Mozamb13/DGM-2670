using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingbox : MonoBehaviour {
	 public Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
		 rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
    } 

}
