/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Zooms in the scope
 */


using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour
{
	bool scoped = false;
	public Texture scope;
	float nextScope;
	public Pause fov;
	int once;

	void Update ()
	{
		
		if (Input.GetMouseButton (1)) {
			scoped = true;
			Camera.main.fieldOfView = 15;

		} else {
			scoped = false;

			Camera.main.fieldOfView = fov.FOV;
		}

	}

	void OnGUI ()
	{
		if (scoped) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), scope, ScaleMode.ScaleAndCrop);

			//fov.sensitivity /= 2;

		}
	}
}
