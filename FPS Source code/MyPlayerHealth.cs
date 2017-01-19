/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script kills the player
 */


using UnityEngine;
using System.Collections;

public class MyPlayerHealth : MonoBehaviour
{

	public int playerHealth = 100;
	public GameObject player;
	public bool isPlayerDead = false;

	[PunRPC]
	void isDead ()
	{
		
		Respawn ();


	}

	public void Respawn ()
	{
		//deaths++;
		PhotonNetwork.LeaveRoom ();
	}
}
