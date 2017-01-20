/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script creates the back button from the credits
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
	void OnGUI ()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 10, 80, 20), "Back")) {
			SceneManager.LoadScene ("Mainmenu");
		}
	}
}
