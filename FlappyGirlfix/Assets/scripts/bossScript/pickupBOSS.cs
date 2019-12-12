using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBOSS : MonoBehaviour {


	public int scoreToGiveBOSS;
	
	private ScoreManagerBOSS theScoreManagerBOSS;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
        theScoreManagerBOSS = FindObjectOfType<ScoreManagerBOSS>();
        coinSound = GameObject.Find("maitoo").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
            theScoreManagerBOSS.AddScoreBOSS(scoreToGiveBOSS);
			gameObject.SetActive(false);
            coinSound.Play();
        }
		
	}
	
}
