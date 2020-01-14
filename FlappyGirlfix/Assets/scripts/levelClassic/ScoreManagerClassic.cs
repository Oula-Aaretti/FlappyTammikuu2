using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerClassic : MonoBehaviour {

	public Text scoreTextClassic;
	public Text hiScoreText1;
	
	public float scoreCountClassic;
	public float hiScoreCount1;
	
	public float pointsPerSecondClassic;
	
	public bool scoreIncreasingClassic;
	
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
		
		if(scoreIncreasingClassic)
		{

            scoreCountClassic += pointsPerSecondClassic * Time.deltaTime;
		}
		if(scoreCountClassic > hiScoreCount1)
		{
			hiScoreCount1 = scoreCountClassic;
			PlayerPrefs.SetFloat("ENNÄTYS1", hiScoreCount1);
		}

        scoreTextClassic.text =  Mathf.Round (scoreCountClassic) + " ";
		hiScoreText1.text = "RECORD: " + Mathf.Round (hiScoreCount1);
		
		if(scoreCountClassic >= hiScoreCount1)
        {
           // scoreTextClassic.text.color.green;
        }

	}
	
	
	public void AddScoreClassic(int pointsToAddClassic)
	{




        scoreCountClassic += pointsToAddClassic;
	}
	
	
	
}
