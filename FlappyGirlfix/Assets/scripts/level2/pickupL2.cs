using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupL2 : MonoBehaviour {


	public int scoreToGive1;
	
	private ScoreManager1 theScoreManager1;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
		theScoreManager1 = FindObjectOfType<ScoreManager1>();
        coinSound = GameObject.Find("maitoo").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			theScoreManager1.AddScore1(scoreToGive1);
			gameObject.SetActive(false);
            coinSound.Play();
        }
		
	}
	
}
