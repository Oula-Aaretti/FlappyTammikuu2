using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {


public Canvas quitMenu;
public Button start1;
public Button start2;
public Button start3;
    public Button start4;
    public Button exitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		
		start2 = start2.GetComponent<Button> ();
		start3 = start3.GetComponent<Button> ();
        
        exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	
	// Update is called once per frame
	public void ExitPress() {
		quitMenu.enabled = true;
		
		start2.enabled = false;
		start3.enabled = false;
        
        exitText.enabled = false;
	}
	
	public void NoPress()
	{
		quitMenu.enabled = false;
		
		start2.enabled = true;
		start3.enabled = true;
       
        exitText.enabled = true;
	}
	
	
	
	public void StartLevel2()
	{
		SceneManager.LoadScene ("tasohyppely");
	}
	public void StartLevel3()
	{
		SceneManager.LoadScene ("flappy");
	}
    
    public void ExitGame()
	{
		Application.Quit ();
	}
	
}
