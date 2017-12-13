using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour {
	 public Rigidbody rb;
     void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = false;
    } 
   
}
