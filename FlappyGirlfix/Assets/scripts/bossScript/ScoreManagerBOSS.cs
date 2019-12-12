using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerBOSS : MonoBehaviour {

	public Text scoreTextBOSS;
	public Text hiScoreText1;
	
	public float scoreCountBOSS;
	public float hiScoreCount1;
	
	public float pointsPerSecondBOSS;
	
	public bool scoreIncreasingBOSS;
	
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
		
		if(scoreIncreasingBOSS)
		{

            scoreCountBOSS += pointsPerSecondBOSS * Time.deltaTime;
		}
		if(scoreCountBOSS > hiScoreCount1)
		{
			hiScoreCount1 = scoreCountBOSS;
			PlayerPrefs.SetFloat("ENNÄTYS1", hiScoreCount1);
		}

        scoreTextBOSS.text =  Mathf.Round (scoreCountBOSS) + "X ";
		hiScoreText1.text = "RECORD: " + Mathf.Round (hiScoreCount1);
		
		if(scoreCountBOSS == 1)
        {
            SceneManager.LoadScene("levelEND");
        }

	}
	
	
	public void AddScoreBOSS(int pointsToAddBOSS)
	{




        scoreCountBOSS += pointsToAddBOSS;
	}
	
	
	
}
