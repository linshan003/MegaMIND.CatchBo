using UnityEngine;
using System.Collections;

public class RecBehaviour : MonoBehaviour 
{
	private Vector3 tempPosition;
	private int life;

	void Awake()
	{
		life = 1;
		tempPosition = transform.position;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		life --;
		if(other.gameObject.tag == "Ball" && life <= 0)
		{
			Destroy(gameObject);
		}
	}

	void HoldPosition()
	{
		transform.position = tempPosition;
		rigidbody2D.velocity = Vector3.zero;
		rigidbody2D.rotation = 0f;
	}

}
