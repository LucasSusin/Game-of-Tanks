using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupScript : MonoBehaviour {
	public int ammoOnTheBox;

	public AudioClip reloadAudio;

	public GameObject cameraPosition2;



	// Use this for initialization
	void Start () {
		cameraPosition2 = GameObject.Find ("Main Camera");
		
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player1" || other.tag == "Player2") 
		{
			int temp = other.GetComponent<TankMov> ().ammo;  
			other.GetComponent<TankMov> ().ammo = temp + ammoOnTheBox;
			AudioSource.PlayClipAtPoint (reloadAudio, cameraPosition2.transform.position);
		}
		Destroy (gameObject);
	}
}
