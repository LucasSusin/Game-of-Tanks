using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	
	public float bulletSpeed;
	private Rigidbody rb;
	public ParticleSystem bulletExplosion;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * bulletSpeed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player1") {
			other.GetComponent<TankMov> ().gm.AddPlayer2Score ();
		}
		if (other.tag == "Player2") {
			other.GetComponent<TankMov> ().gm.AddPlayer1Score ();
		}
	
		Instantiate (bulletExplosion, transform.position, transform.rotation);

		Destroy (gameObject);

	}
}