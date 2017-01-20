/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Picks up weapons
 */

using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
	public int id;
	public GameObject player;

	void OnTriggerEnter ()
	{
/*
		if (id == 1) {
			player.GetComponent<Equipped> ().m4 = true;
		} else if (id == 2) {
			player.GetComponent<Equipped> ().m4 = true;
			Debug.Log ("Sniper");
		}
*/
		Destroy (gameObject);
	}
}

