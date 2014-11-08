using UnityEngine;
using System.Collections;

public class ChangeYByBoundary : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Vector3 velocity = other.gameObject.rigidbody2D.velocity;
		other.gameObject.rigidbody2D.velocity = new Vector3 (velocity.x, -1 * velocity.y, velocity.z);
	}
}
