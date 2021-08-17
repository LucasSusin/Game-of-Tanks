using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManagerScript : MonoBehaviour {


	public Text timeText; 
	public Text greenScoreText;
	public Text blueScoreText;

	public int inicialTime;

	public GameObject player1;
	public GameObject player2;
	public int greenTankScore;
	public int blueTankScore;
	public float timeBetweenAmmoSpawns;
	public Transform [] spawnPointsLocations;
	public GameObject ammoPickup;

	// Use this for initialization
	void Start () {
		inicialTime = PlayerPrefs.GetInt ("Time");
		greenTankScore = 0;
		blueTankScore = 0;
		InvokeRepeating ("DecreaseTime", 1.0f, 1.0f);
		InvokeRepeating ("spawnAmmo", timeBetweenAmmoSpawns, timeBetweenAmmoSpawns);	
		
	}
	
	// Update is called once per frame
	void Update () {
		greenScoreText.text = "Score: " + greenTankScore.ToString ();
		blueScoreText.text = "Score: " + blueTankScore.ToString ();
		timeText.text = "Time: " + inicialTime.ToString ();

		if (inicialTime <= 0) 
		{
			PlayerPrefs.SetInt ("GreenScore", greenTankScore);
			PlayerPrefs.SetInt ("BlueScore", blueTankScore);
			CancelInvoke();
			SceneManager.LoadScene ("GameOver");
		}
		
	}
	public void AddPlayer1Score()
	{
		greenTankScore++;
	}
	public void AddPlayer2Score()
	{
		blueTankScore++;

	}
	public void DecreaseTime()
	{
		inicialTime--;


	}

	public void spawnAmmo()
	{
		int temp = Random.Range (0, spawnPointsLocations.Length);
		Instantiate (ammoPickup, spawnPointsLocations [temp].transform.position, spawnPointsLocations [temp].transform.rotation);


			}



}
