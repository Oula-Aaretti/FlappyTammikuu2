using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deathMenuClassic : MonoBehaviour {

	
		
	public string mainMenuLevel;
	
	public void RestartGame()
	{
		FindObjectOfType<THGameManagerClassic>().Reset();
	}
	
	public void QuitTiMain()
	{
		SceneManager.LoadScene ("menu");
	}
	
	
	
	
	
	
}
