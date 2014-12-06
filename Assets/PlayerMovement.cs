using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float maxSpeed = 20F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		float xxMovment = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector3 (xxMovment * maxSpeed, rigidbody2D.velocity.y);	



		float yyMovment = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector3 (yyMovment * maxSpeed, rigidbody2D.velocity.x);	
	}
}
