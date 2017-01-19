/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script shows inventory
 */


using UnityEngine;
using System.Collections;

public class Inv : MonoBehaviour
{
	public Texture pistol;
	public Texture m4;
	public Texture sniper;

	void OnGUI ()
	{
	
		GUI.Box (new Rect (Screen.width - 150, Screen.height / 2 - 100, 150, 200), "");

		GUI.DrawTexture (new Rect (Screen.width - 125, Screen.height / 2 - 50, 100, 55), pistol);
		GUI.DrawTexture (new Rect (Screen.width - 125, Screen.height / 2, 100, 30), m4);
		GUI.DrawTexture (new Rect (Screen.width - 125, Screen.height / 2 + 50, 100, 20), sniper);

		//GUI.Label (new Rect (Screen.width - 85, Screen.height / 2 - 15, 80, 20), "Click 1 for:");
	}
}
