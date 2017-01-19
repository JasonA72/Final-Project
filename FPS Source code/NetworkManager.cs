/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Connects to a server
 */


using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{

	public Camera mapCamera;
	SpawnPlayers[] spawnSpots;
	int teamId = 2;
	bool chooseTeam;



	void Start ()
	{
		spawnSpots = GameObject.FindObjectsOfType<SpawnPlayers> ();
		Connect ();
	}


	void Connect ()
	{
		chooseTeam = true;

	}

	void OnGUI ()
	{
		
		//GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
		if (chooseTeam) {
			GUI.Label (new Rect (Screen.width / 2 - 45, 150, 120, 20), "Choose a team");

			if (GUI.Button (new Rect (Screen.width / 2 - 100, 200, 200, 20), "Counter Terrorist")) {
				teamId = 0;
				chooseTeam = false;
				PhotonNetwork.autoJoinLobby = true;
				PhotonNetwork.ConnectUsingSettings ("1.0");
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 100, 250, 200, 20), "Terrorist")) {
				teamId = 1;
				chooseTeam = false;
				PhotonNetwork.autoJoinLobby = true;
				PhotonNetwork.ConnectUsingSettings ("1.0");
			}
		}

	}

	void OnJoinedLobby ()
	{
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed ()
	{
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom ()
	{
		SpawnMyPlayer ();
	}

	public void SpawnMyPlayer ()
	{
		
		//OnGUI ();

		if (spawnSpots == null) {
			Debug.LogError ("No Spawns");
			return;
		}

		SpawnPlayers mySpawn = spawnSpots [teamId];

		GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate ("Player", mySpawn.transform.position, mySpawn.transform.rotation, 0);
		mapCamera.enabled = false;



		myPlayer.GetComponent<MoveCamera> ().enabled = true;
		myPlayer.GetComponent<Grounded> ().enabled = true;
		myPlayer.transform.FindChild ("Main Camera").gameObject.SetActive (true);
		myPlayer.GetComponent<Crosshair> ().enabled = true;
		myPlayer.GetComponent<MyPlayerHealth> ().enabled = true;
		myPlayer.GetComponentInChildren<Pause> ().enabled = true;
		myPlayer.GetComponent<Inv> ().enabled = true;
		myPlayer.GetComponent<Equipped> ().enabled = true;
		myPlayer.GetComponent<Zoom> ().enabled = true;
		myPlayer.GetComponent<Jump> ().enabled = true;
		myPlayer.GetComponent<Scoreboard> ().enabled = true;
		//myPlayer.GetComponentInChildren<Respawn> ().enabled = true;



	}
}
