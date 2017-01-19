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
