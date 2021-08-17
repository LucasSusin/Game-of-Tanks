using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeObjectDestructor : MonoBehaviour {


	public float timeToDestroy;



	// Use this for initialization
	void Start () {
		Invoke ("DestroyGameObject", timeToDestroy);	
	}
	
	public void DestroyGameObject()
	{
		Destroy (gameObject);
	}
}
