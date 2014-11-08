using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public Camera cam ;
	public float maxVX;
	public float maxVY;

	private float maxWidth;

	void Start()
	{
		if(cam == null)
		{
			cam = Camera.main;
		}

		Vector3 maxRange = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (maxRange);
		float playerWidth = renderer.bounds.extents.x;
		maxWidth = targetWidth.x - playerWidth;
	}

	void Update()
	{
		float x = rigidbody2D.velocity.x;
		float y = rigidbody2D.velocity.y;
		//x = Mathf.Clamp (x, -maxVX, maxVX);
		//y = Mathf.Clamp (y, -maxVX, maxVY);
		rigidbody2D.velocity = new Vector3 (Mathf.Clamp (x, -maxVX, maxVX), Mathf.Clamp (y, -maxVX, maxVY), 0.0f);
	}

	void FixedUpdate()
	{
		Vector3 MousePosition = cam.ScreenToWorldPoint (Input.mousePosition);
		Vector3 targetPosition = new Vector3 (MousePosition.x, -4.61f, 0.0f);
		float targetX = Mathf.Clamp (targetPosition.x, -maxWidth, maxWidth);
		targetPosition = new Vector3 (targetX, -4.61f, transform.position.z);
		rigidbody2D.MovePosition (targetPosition);
		rigidbody2D.rotation = 0.0f;
	}
}
