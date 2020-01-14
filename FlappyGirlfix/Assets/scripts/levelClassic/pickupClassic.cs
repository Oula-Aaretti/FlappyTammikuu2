using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupClassic : MonoBehaviour {


	public int scoreToGiveClassic;
	
	private ScoreManagerClassic theScoreManagerClassic;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
        theScoreManagerClassic = FindObjectOfType<ScoreManagerClassic>();
        coinSound = GameObject.Find("maitoo").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
            theScoreManagerClassic.AddScoreClassic(scoreToGiveClassic);
			gameObject.SetActive(false);
            coinSound.Play();
        }
		
	}
	
}
