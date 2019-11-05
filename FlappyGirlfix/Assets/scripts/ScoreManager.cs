using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text hiScoreText;
	
	public float scoreCount;
	public float hiScoreCount;
	
	public float pointsPerSecond;
	
	public bool scoreIncreasing;
	
	public bool shouldDouble;



	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("ENNÄTYS"))
		{
			hiScoreCount = PlayerPrefs.GetFloat("ENNÄTYS");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(scoreIncreasing)
		{
		
			scoreCount += pointsPerSecond * Time.deltaTime;
		}
		if(scoreCount > hiScoreCount)
		{
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat("ENNÄTYS", hiScoreCount);
		}
		
		scoreText.text = "PISTEET: " + Mathf.Round (scoreCount);
		hiScoreText.text = "ENNÄTYS: " + Mathf.Round (hiScoreCount);
		
		
	}
	
	
	public void AddScore(int pointsToAdd)
	{
		
		if(shouldDouble)
		{
			pointsToAdd = pointsToAdd * 10;
			scoreCount += (pointsPerSecond*10)*Time.deltaTime;
		}
		
		
		scoreCount += pointsToAdd;
	}
	
	
	
}
