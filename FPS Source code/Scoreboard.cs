/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script shows the scoreboard
 */


using UnityEngine;
using System.Collections;

public class Scoreboard : MonoBehaviour
{

	bool scoreboard;
	public Texture scoreboardBG;

	void Update ()
	{

		if (Input.GetKey (KeyCode.Tab)) {
			scoreboard = true;
		} else {
			scoreboard = false;
		}

	}

	void OnGUI ()
	{
		if (scoreboard) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), scoreboardBG);
		}
	}
}
