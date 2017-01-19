/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Creates buttons on the main menu
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
	void OnGUI ()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 10, 80, 20), "Start")) {
			SceneManager.LoadScene ("Scene");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 35, 80, 20), "Credits")) {
			SceneManager.LoadScene ("Credits");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 80, 80, 20), "Exit")) {
			Application.Quit ();
		}
	}
}

