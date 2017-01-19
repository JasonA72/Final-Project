/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script makes sprites face the player
 */


using UnityEngine;
using System.Collections;

public class Faceplayer : MonoBehaviour
{
	public Transform target;

	void Awake ()
	{
		transform.LookAt (target);
	}

}
