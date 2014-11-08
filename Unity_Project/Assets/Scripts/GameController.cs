using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject ball ;
	public GameObject player;
	public Vector3 initialVelocity;
	public Vector3 initialPosition;
	public GameObject wall;

	void Start()
	{
		ball.rigidbody2D.velocity = initialVelocity;
		ball.rigidbody2D.position = initialPosition;

		for(int j = 0; j < 3 ; j++)
		{
			for(int i = 0; -7.7f + 1.9f * i < 6; i += 1)
			{
				Vector3 wallPosition = new Vector3(-7.7f+1.9f*i, 4.4f - j,0.0f);
				Instantiate(wall, wallPosition, Quaternion.identity);
			}
		}
	}
}
