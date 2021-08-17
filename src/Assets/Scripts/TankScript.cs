using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour {
    //variáveis que armazenam a velocidade do tanque 
    public float tankSpeed;
    public float tankTurnSpeed;
    public GameObject bullet;
    public Transform bulletPosition;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * tankSpeed;
        float rotation = Input.GetAxis("Horizontal") * tankTurnSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
        }
    }
}
