/* Created by: Jason Azevedo
 * Created on: January 19, 2017
 * This Script Shoots
 */


using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{

	public int gunDamage = 0;
	public float fireRate = 0f;
	public Transform gunEnd;
	public Pause isPause;
	public bool isKilled;
	public GameObject bulletHole;
	public GameObject muzzleFlash;

	private Camera fpsCam;
	private WaitForSeconds shotDuration = new WaitForSeconds (.07f);
	private AudioSource gunAudio;
	private LineRenderer laserLine;
	private float nextFire;



	void Start ()
	{
		//laserLine = GetComponent<LineRenderer> ();
		gunAudio = GetComponent<AudioSource> ();
		fpsCam = GetComponentInParent<Camera> ();
	}


	void Update ()
	{
	
		if (isPause.isPause == false) {
			

			if (Input.GetMouseButton (0) && Time.time > nextFire) {
		
				nextFire = Time.time + fireRate;

				StartCoroutine (ShotEffect ());

				Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
				RaycastHit hit;

				//laserLine.SetPosition (0, gunEnd.position);

				if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit)) {
					//laserLine.SetPosition (1, hit.point);
					//hit.transform.gameObject.GetComponent<MyPlayerHealth> ().playerHealth = 0;

					if (hit.collider.gameObject.tag == "Player") {


						//hit.collider.enabled = false;
						//hit.collider.gameObject.GetComponent<MyPlayerHealth> ().isPlayerDead = true;

						//hit.transform.GetComponent<PhotonView> ().RPC ("");

						//THIS WORKS WITH A 1v1 ALSO KNOWN AS EVERYONE ELSE DIES EXCEPT SHOOTER

						hit.transform.GetComponent<PhotonView> ().RPC ("isDead", PhotonTargets.Others);


					} else {


						//hit.textureCoord = bulletHole;
						Instantiate (bulletHole, hit.point, Quaternion.identity);

						//Get Collider Rotation, Place on direction z?

						//Instantiate (muzzleFlash, gunEnd.transform.position, Quaternion.identity);
					}


				} else {
					//laserLine.SetPosition (1, rayOrigin + (fpsCam.transform.forward * 50f));
				}




			}

		}

	}

	private IEnumerator ShotEffect ()
	{
		gunAudio.Play ();

		//laserLine.enabled = true;
		yield return shotDuration;
		//laserLine.enabled = false;
	}
}
