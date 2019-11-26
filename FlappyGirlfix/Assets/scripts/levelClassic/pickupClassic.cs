using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupClassic : MonoBehaviour {


	public int scoreToGiveL2r;
	
	private ScoreManagerL2r theScoreManagerL2r;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
        theScoreManagerL2r = FindObjectOfType<ScoreManagerL2r>();
        coinSound = GameObject.Find("maitoo").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
            theScoreManagerL2r.AddScoreL2r(scoreToGiveL2r);
			gameObject.SetActive(false);
            coinSound.Play();
        }
		
	}
	
}
