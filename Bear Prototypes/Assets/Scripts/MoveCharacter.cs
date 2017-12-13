using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MoveCharacter : MonoBehaviour {
	Animator anims;
	CharacterController cc;
	Vector3 tempMove;  
	public float speed = 5;
	public float gravity = 1;
	private float jumpHeight = 0.7f;
	public bool isGrounded = true;
	public float jumpCount = 2;
	
	void Start(){
        PlayButton.Play += OnPlay;
    }
	void OnPlay(){
		anims = GetComponent<Animator>();
		cc = GetComponent<CharacterController>();
		MoveInput.KeyAction += Move;
		MoveInput.JumpAction = Jump;
	}
	
	void Jump(){
		tempMove.y = jumpHeight;
		anims.SetTrigger("Jump");
		if (cc.isGrounded == true){
			jumpCount = 2;
		}
		if (jumpCount != 0){
			jumpCount -= 1;
			print(jumpCount);
			
			
		}
	}
	void Move (float _movement) {
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x=_movement*speed*Time.deltaTime;
		cc.Move(tempMove);
		if(gameObject.transform.position.z !=-12.73)
		{
			Vector3 temp = cc.transform.position;
			temp.z = -12.73f;
			cc.transform.position = temp;
		}
		anims.SetFloat("Speed", Mathf.Abs(_movement));
	}

}
