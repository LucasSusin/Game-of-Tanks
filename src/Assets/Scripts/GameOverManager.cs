using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverManager : MonoBehaviour {

	public Text blueScoreText;
	public Text greenScoreText;

	// Use this for initialization
	void Start () {
		blueScoreText.text = "Blue Score: "	+ PlayerPrefs.GetInt ("BlueScore"); 
		greenScoreText.text = "Green Score: "	+ PlayerPrefs.GetInt ("GreenScore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
