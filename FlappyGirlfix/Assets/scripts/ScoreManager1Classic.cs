using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager1Classic : MonoBehaviour {

	public Text scoreText1;
	public Text hiScoreText1;
	
	public float scoreCount1;
	public float hiScoreCount1;
	
	public float pointsPerSecond1;
	
	public bool scoreIncreasing1;
	
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
		
		if(scoreIncreasing1)
		{
		
			scoreCount1 += pointsPerSecond1 * Time.deltaTime;
		}
		if(scoreCount1 > hiScoreCount1)
		{
			hiScoreCount1 = scoreCount1;
			PlayerPrefs.SetFloat("ENNÄTYS1", hiScoreCount1);
		}
		
		scoreText1.text =  Mathf.Round (scoreCount1) + " ";
		hiScoreText1.text = "RECORD: " + Mathf.Round (hiScoreCount1);
		
		if(scoreCount1 == 10)
        {
            //SceneManager.LoadScene("flappy3");
        }

	}
	
	
	public void AddScore1(int pointsToAdd1)
	{
		
		
		
		
		scoreCount1 += pointsToAdd1;
	}
	
	
	
}
