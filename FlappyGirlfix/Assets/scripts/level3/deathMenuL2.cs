using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deathMenu3 : MonoBehaviour {

	
		
	public string mainMenuLevel;
	
	public void RestartGame()
	{
		FindObjectOfType<THGameManager1>().Reset();
	}
	
	public void QuitTiMain()
	{
		SceneManager.LoadScene ("menu");
	}
	
	
	
	
	
	
}
