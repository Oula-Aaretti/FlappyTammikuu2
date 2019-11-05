using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class takasinmenuun : MonoBehaviour {


public Canvas quitMenu;
public Button startText;
public Button exitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	
	// Update is called once per frame
	public void ExitPress() {
		quitMenu.enabled = true;
		startText.enabled = true;
		exitText.enabled = false;
	}
	
	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}
	
	
	public void StartLevel()
	{
		SceneManager.LoadScene ("menu");
	}
	
	public void ExitGame()
	{
		Application.Quit ();
	}
	
}
