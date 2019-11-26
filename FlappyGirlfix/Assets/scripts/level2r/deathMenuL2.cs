using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deathMenuL2r : MonoBehaviour {

	
		
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
