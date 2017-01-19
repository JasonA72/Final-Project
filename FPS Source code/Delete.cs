/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Deletes the players
 */


using UnityEngine;
using System.Collections;

public class Delete : MonoBehaviour
{


	void OnAwake ()
	{
		Destroy (gameObject);
	}
}
