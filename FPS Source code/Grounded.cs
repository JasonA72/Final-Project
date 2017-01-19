/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Checks if the players is grounded
 */


using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour
{

	public GameObject player;
	RaycastHit hit;
	public Jump ground;

	void Update ()
	{



		if (Input.GetKeyDown (KeyCode.Space)) {

			if (Physics.Raycast (transform.position, transform.TransformDirection (new Vector3 (0, -1, 0)), 1.1f)) {
				ground.isGrounded = true;
			} else {
				ground.isGrounded = false;
			}


			/*

			Ray ray = 
				
			if (Physics.Raycast (, out hit)) {
				if (hit.collider != null) {
					Vector3 ground = hit.point;
				}
			}

			transform.position = pos;
		}
*/
		
	
		}
	}
}