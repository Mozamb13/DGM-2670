using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart : MonoBehaviour {
public Transform DartHead;
	public float headspeed;
	void Update(){
        DartHead.transform.position += new Vector3(0, headspeed*Time.deltaTime, 0);
    }

    void OnTriggerEnter (Collider other) {
        if (other.tag == "EnemyPatrol"){
            headspeed = -headspeed;
        }
    }
	
}