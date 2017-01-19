/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Moves and looks around
 */


using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{

	public Pause isPause;

	float speed = 0.3f;

	float verticalRotation = 0;
	public float upDownRange = 60.0f;

	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update ()
	{
		if (isPause.isPause == false) {

			float rotLeftRight = Input.GetAxis ("Mouse X") * isPause.sensitivity;
			transform.Rotate (0, rotLeftRight, 0);


			verticalRotation -= Input.GetAxis ("Mouse Y") * isPause.sensitivity;
			verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
			Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

			Quaternion rot = transform.rotation;
			Vector3 pos = transform.position;

			Vector3 velocity = new Vector3 (Input.GetAxis ("Horizontal") * speed, 0, Input.GetAxis ("Vertical") * speed);


			if (Input.GetKey (KeyCode.LeftShift)) {
				speed = 0.2f;
			} else {
				speed = 0.1f;
			}
			pos += rot * velocity;

			transform.position = pos;
			transform.rotation = rot;



		}
	}
}
