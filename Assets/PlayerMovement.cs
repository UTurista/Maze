using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	//Caracter Speed
	public float speed = 20F;

	//Speed Multiplier if Button "Turbo" is being pressed
	public float turboMultiplier = 3F;


	// Update is called once per frame
	void Update () {
		//Speed multiplier, default 1
		float multiplier =  Input.GetButton("Turbo") ? turboMultiplier : 1F;
	
		//Vertical movement
		float xxMovment = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector3 (xxMovment * speed * multiplier, rigidbody2D.velocity.y);	

		//Horizontal movement
		float yyMovment = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector3 (yyMovment * speed * multiplier, rigidbody2D.velocity.x);	
	}
}
