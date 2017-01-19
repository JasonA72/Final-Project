/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Equips weapons
 */


using UnityEngine;
using System.Collections;

public class Equipped : MonoBehaviour
{

	public GameObject M24A1;
	public GameObject Pistol;
	public GameObject M4;
	public bool fullAuto = false;
	//Equipped scope;

	void Update ()
	{


		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			M24A1.SetActive (false);
			M4.SetActive (false);
			Pistol.SetActive (true);
			fullAuto = false;



		}
	

		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			M24A1.SetActive (false);
			M4.SetActive (true);
			Pistol.SetActive (false);
			fullAuto = true;
		}

		//print(sniper);

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			M24A1.SetActive (true);
			M4.SetActive (false);
			Pistol.SetActive (false);
			fullAuto = false;
			/*if (Input.GetMouseButtonDown (1)) {
				scope.scoped = true;
			}*/

		}



	}
}
