using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerL2r : MonoBehaviour {

	public Text scoreTextL2r;
	public Text hiScoreText1;
	
	public float scoreCountL2r;
	public float hiScoreCount1;
	
	public float pointsPerSecondL2r;
	
	public bool scoreIncreasingL2r;
	
	public bool shouldDouble1;



	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("ENNÄTYS1"))
		{
			hiScoreCount1 = PlayerPrefs.GetFloat("ENNÄTYS1");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(scoreIncreasingL2r)
		{

            scoreCountL2r += pointsPerSecondL2r * Time.deltaTime;
		}
		if(scoreCountL2r > hiScoreCount1)
		{
			hiScoreCount1 = scoreCountL2r;
			PlayerPrefs.SetFloat("ENNÄTYS1", hiScoreCount1);
		}

        scoreTextL2r.text =  Mathf.Round (scoreCountL2r) + "/15 ";
		hiScoreText1.text = "RECORD: " + Mathf.Round (hiScoreCount1);
		
		if(scoreCountL2r == 15)
        {
            SceneManager.LoadScene("level3");
        }

	}
	
	
	public void AddScoreL2r(int pointsToAddL2r)
	{
		
		
		
		
		scoreCountL2r += pointsToAddL2r;
	}
	
	
	
}
