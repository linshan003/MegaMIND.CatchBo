using UnityEngine;
using System.Collections;

public class ChangeXByBoundary : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Vector3 velocity = other.gameObject.rigidbody2D.velocity;
		other.gameObject.rigidbody2D.velocity = new Vector3 (-1 * velocity.x, velocity.y, velocity.z);
	}
}
