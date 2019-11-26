using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup3 : MonoBehaviour {


	public int scoreToGive3;
	
	private ScoreManager3 theScoreManager3;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
        theScoreManager3 = FindObjectOfType<ScoreManager3>();
        coinSound = GameObject.Find("maitoo").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
            theScoreManager3.AddScore3(scoreToGive3);
			gameObject.SetActive(false);
            coinSound.Play();
        }
		
	}
	
}
