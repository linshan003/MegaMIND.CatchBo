using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public Camera cam ;


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
