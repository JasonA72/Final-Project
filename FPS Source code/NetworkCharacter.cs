/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script makes the players look good when they move on the server
 */


using UnityEngine;
using System.Collections;

public class NetworkCharacter : Photon.MonoBehaviour
{
	Vector3 realPos = Vector3.zero;
	Quaternion realRot = Quaternion.identity;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (photonView.isMine) {
			
		} else {
			transform.position = Vector3.Lerp (transform.position, realPos, 0.1f);
			transform.rotation = Quaternion.Lerp (realRot, realRot, 0.1f);
		}
	}

	void OnPhotonSerializeView (PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting) {

			stream.SendNext (transform.position);
			stream.SendNext (transform.rotation);

		} else {
			realPos = (Vector3)stream.ReceiveNext ();
			realRot = (Quaternion)stream.ReceiveNext ();
		}
	}
}
