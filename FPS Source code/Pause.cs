/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Pauses the game
 */


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

	public bool isPause = false;
	bool isOptions = false;
	bool isMenu = false;
	float unPause;
	//	float timeToNextPause = 0.5f;
	public float sensitivity = 5f;
	public float FOV = 60f;




	// Use this for initialization
	void Start ()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	
		if (Input.GetKeyDown (KeyCode.Escape)) {

			if (!isOptions) {
				isMenu = !isMenu;
				isPause = !isPause;
			}
		}

		if (isPause) {
			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;
		} else {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}


	}


	void OnGUI ()
	{
		if (isMenu) {
			GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "Game Paused");

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 50, 80, 20), "Resume")) {
				isPause = false;
				isMenu = false;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 15, 80, 20), "Options")) {
				isOptions = true;	
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 25, 80, 20), "Mainmenu")) {
				SceneManager.LoadScene ("Mainmenu");
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 75, 80, 20), "Quit")) {
				Application.Quit ();
			}
		

		}

		if (isOptions) {
			isMenu = false;

			GUI.Box (new Rect (Screen.width - Screen.width, Screen.height - Screen.height, Screen.width, Screen.height), "Options");


			GUI.Label (new Rect (20, 114, 120, 20), "Sensitivity : " + Mathf.RoundToInt (sensitivity));
			sensitivity = GUI.HorizontalSlider (new Rect (150, 120, 100, 20), sensitivity, 1, 5);

			GUI.Label (new Rect (20, 150, 120, 20), "FOV : " + Mathf.RoundToInt (FOV));
			FOV = GUI.HorizontalSlider (new Rect (150, 156, 100, 20), FOV, 60, 120);
			Camera.main.fieldOfView = FOV;

			if (GUI.Button (new Rect (Screen.width / 2 - 80, Screen.height / 2 + 40, 160, 40), "Back")) {
				isMenu = true;
				isOptions = false;
			}
		
		}

	}
}
