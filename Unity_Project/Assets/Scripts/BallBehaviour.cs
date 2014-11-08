using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public Vector3 InitialVelocity;
	public float maxVX;
	public float maxVY;
	public GameObject player;

	private bool activate;

	void Start ()
	{
		activate = false;
		rigidbody2D.velocity = Vector3.zero;
	}
	

	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
	    {
			activate = true;
			rigidbody2D.velocity = InitialVelocity;
		}
		if(!activate)
		{
			FollowPlayer();
		}

		VelocityControl ();
	}

	void VelocityControl()
	{
		float x = rigidbody2D.velocity.x;
		float y = rigidbody2D.velocity.y;
		//x = Mathf.Clamp (x, -maxVX, maxVX);
		//y = Mathf.Clamp (y, -maxVX, maxVY);
		rigidbody2D.velocity = new Vector3 (Mathf.Clamp (x, -maxVX, maxVX), Mathf.Clamp (y, -maxVX, maxVY), 0.0f);
	}
	void FollowPlayer()
	{
		Vector3 temp = new Vector3 (player.transform.position.x, player.transform.position.y + 0.9f, transform.position.z);
		transform.position = temp;
	}














}
