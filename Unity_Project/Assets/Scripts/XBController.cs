using UnityEngine;
using System.Collections;

public class XBController : MonoBehaviour 
{

	public float speed;
	public Camera cam;


	private float maxWidth;

	void Start()
	{
		if(cam == null)
		{
			cam = Camera.main;
		}

		Vector3 upConner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upConner);
		float BoWidth = renderer.bounds.extents.x;

		maxWidth = targetWidth.x - BoWidth;

		rigidbody2D.velocity = new Vector3 (speed, 0.0f, 0.0f);
	}

	void Update()
	{
		if(transform.position.x >= maxWidth || transform.position.x <= -maxWidth)
		{
			speed *= -1;
			rigidbody2D.velocity = new Vector3(speed, 0.0f, 0.0f);
			//yield return WaitForSeconds(2.0f);
		}

	}


}
