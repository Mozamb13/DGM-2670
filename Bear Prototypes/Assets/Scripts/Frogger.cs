using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour {
Animator anims;
public Transform frogman;
	public float hopalong;
    void Start()
    {
        anims = GetComponent<Animator>();
    }
	void Update(){
        frogman.transform.position += new Vector3(0, hopalong*Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lillypad"){
            hopalong = -hopalong;
            anims.SetTrigger("Jump");
            print("hop-a-long");
        }
         if (other.tag == "EnemyPatrol"){
             hopalong = -hopalong;
             anims.SetTrigger("Fall");
         }
	}
}
