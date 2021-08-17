using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankMov : MonoBehaviour {
	public float speed;

	public float turnSpeed;

	public GameObject bullet;

	public AudioClip cannonFireAudio;

	public Transform cameraPosition;

	public Transform bulletPosition;

	public int ammo;

	public GameManagerScript gm;

	public Text ammoText;

	public int playerNumber;
	private string axisHorizontalName;
	private string axisVerticalName;


	private Rigidbody rb;

	private float horizontalAxisInput;
	private float verticalAxisInput;
	private string fireButtonName;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		axisHorizontalName = "Horizontal" + playerNumber. ToString();
		axisVerticalName = "Vertical"  + playerNumber. ToString();
		fireButtonName = "Fire" +playerNumber. ToString();

	}
	
	// Update is called once per frame
	void Update () {
		horizontalAxisInput = Input.GetAxis (axisHorizontalName);
		verticalAxisInput = Input.GetAxis (axisVerticalName);

		ammoText.text = "Ammo: " + ammo.ToString ();
		if (Input.GetButtonDown(fireButtonName) && (ammo >=1))
		{
			Instantiate(bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
			ammo--;
			AudioSource.PlayClipAtPoint (cannonFireAudio, cameraPosition.transform.position, 0.5f);
		}

	}


	private void FixedUpdate ()
	{
		Move ();
		Turn ();

	}
	private void Move()
	{
		Vector3 movement = transform.forward * verticalAxisInput * speed * Time.deltaTime;
		rb.MovePosition(rb.position + movement);

	}
	private void Turn()
	{
		float turn = horizontalAxisInput * turnSpeed * Time.deltaTime;

		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);

		rb.MoveRotation (rb.rotation * turnRotation);
 	}		
}
