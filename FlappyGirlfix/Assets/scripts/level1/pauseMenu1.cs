using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu1 : MonoBehaviour {

	
		
	public string mainMenuLevel;
	
	public GameObject pauseMenuu;
	
	public void PauseGame()
	{
		Time.timeScale = 0f;
		pauseMenuu.SetActive(true);
	}
	
	public void ResumeGame()
	{
		Time.timeScale = 1f;
		pauseMenuu.SetActive(false);
	}
	
	public void RestartGame()
	{
		Time.timeScale = 1f;
		pauseMenuu.SetActive(false);
		FindObjectOfType<THGameManager1>().Reset();
	}
	
	public void QuitTiMain()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("menu");
	}
	
	
	
	
	
	
}
