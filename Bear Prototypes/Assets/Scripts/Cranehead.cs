using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cranehead : MonoBehaviour {
	public Transform craneHead;
	public float headspeed;
   void Update()
    {
      craneHead.transform.position += new Vector3(0, headspeed*Time.deltaTime, 0);  
    }
    void OnTriggerEnter (Collider other) {
        if (other.tag == "EnemyPatrol"){
            headspeed = -headspeed;
            
        }
        
    }
	
}
