using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager3 : MonoBehaviour {

	public Text scoreText3;
	public Text hiScoreText1;
	
	public float scoreCount3;
	public float hiScoreCount1;
	
	public float pointsPerSecond3;
	
	public bool scoreIncreasing3;
	
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
		
		if(scoreIncreasing3)
		{

            scoreCount3 += pointsPerSecond3 * Time.deltaTime;
		}
		if(scoreCount3 > hiScoreCount1)
		{
			hiScoreCount1 = scoreCount3;
			PlayerPrefs.SetFloat("ENNÄTYS1", hiScoreCount1);
		}

        scoreText3.text =  Mathf.Round (scoreCount3) + "/20 ";
		hiScoreText1.text = "RECORD: " + Mathf.Round (hiScoreCount1);
		
		if(scoreCount3 == 20)
        {
            SceneManager.LoadScene("level4");
        }

	}
	
	
	public void AddScore3(int pointsToAdd3)
	{
		
		
		
		
		scoreCount3 += pointsToAdd3;
	}
	
	
	
}
