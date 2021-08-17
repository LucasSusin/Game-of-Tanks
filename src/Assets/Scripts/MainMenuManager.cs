using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour {

	public string level1;
	public string level2;
	
	private string levelSelected;
	private int timeSelected;
	
	void Start()
	{
		levelSelected = level1;
	}

	public void StartGame()
	{
		SceneManager.LoadScene (levelSelected);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
	
	public void SelectArena (int arena)
	{
		if (arena == 1)
			levelSelected = level1;
		if (arena == 2)
			levelSelected = level2;
	}
	
	public void SelectTime (int time)
	{
		if (time == 1)
			timeSelected = 45;
		if (time == 2)
			timeSelected = 90;
		if (time == 3)
			timeSelected = 150;
		PlayerPrefs.SetInt ("Time", timeSelected);
	}
}
