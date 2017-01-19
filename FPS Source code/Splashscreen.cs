/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script shows the splash screen
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Splashscreen : MonoBehaviour
{
	int timer = 0;

	void Update ()
	{
		timer++;
		if (timer > 100) {
			SceneManager.LoadScene ("Mainmenu");
		}
	}
}
