using UnityEngine;
using System.Collections;

//master
public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}	

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveJump = Input.GetAxis ("Up");

		Vector3 movement = new Vector3 (moveHorizontal, moveJump * 50, moveVertical);
		rb.AddForce (movement);

	}

}