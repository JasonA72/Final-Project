/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script is a use key
 */


using UnityEngine;
using System.Collections;

public class clickButton : MonoBehaviour
{



	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.E)) {

			Vector3 rayOrigin = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
			RaycastHit hit;



			if (Physics.Raycast (rayOrigin, Camera.main.transform.forward, out hit)) {

				if (hit.collider.gameObject.tag == "Button") {
					
				}

			}
		}

	}
}
