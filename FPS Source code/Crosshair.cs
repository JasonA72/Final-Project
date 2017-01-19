/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Creates a crosshair
 */

using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour
{

	public Texture crosshair;
	public Pause isPause;

	void OnGUI ()
	{
		if (isPause.isPause == false) {
			GUI.DrawTexture (new Rect (Screen.width / 2 - 10, Screen.height / 2 - 10, 20, 20), crosshair, ScaleMode.ScaleAndCrop);
		}
	}
}
