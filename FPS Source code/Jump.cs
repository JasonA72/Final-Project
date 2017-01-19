/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Jumps
 */


using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{

	public Rigidbody rb;
	public bool isGrounded = false;
	public GameObject player;
	float vVelocity = 2;

	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true) {
			
			Vector3 verticalVelocity = new Vector3 (0, vVelocity, 0);

			transform.position += verticalVelocity;


		}
	}
}
