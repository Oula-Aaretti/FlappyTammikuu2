using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class THGameManagerL2r : MonoBehaviour {


	public Transform platformGenerator;
	private Vector3 platformStartPoint;
	
	public PlayerControllerL2r thePlayer;
	private Vector3 playerStartPoint;
	
	private PlatformDestroy[] platformList;
	
	private ScoreManagerL2r theScoreManagerL2r;
	
	public deathMenu1 theDeathScreen;
	


	// Use this for initialization
	void Start () {
		platformStartPoint = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;

        theScoreManagerL2r = FindObjectOfType<ScoreManagerL2r>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void RestartGame1()
	{

        theScoreManagerL2r.scoreIncreasingL2r = false;
		thePlayer.gameObject.SetActive(false);
		
		//theDeathScreen.gameObject.SetActive(true);
        SceneManager.LoadScene("flappy2");
        //StartCoroutine ("RestartGameCo");

    }
	
	public void Reset()
	{
		
		/*theDeathScreen.gameObject.SetActive(false);
		
		platformList = FindObjectsOfType<PlatformDestroy>();
		for(int i = 0; i < platformList.Length; i++)
		{
			platformList[i].gameObject.SetActive(false);
		}
		
		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive(true);
		
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
		
		powerupReset = true;*/
		
		SceneManager.LoadScene ("flappy2");
	}
	
	
	
	
	/*public IEnumerator RestartGameCo()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive(false);
		yield return new WaitForSeconds(1f);
		platformList = FindObjectsOfType<PlatformDestroy>();
		for(int i = 0; i < platformList.Length; i++)
		{
			platformList[i].gameObject.SetActive(false);
		}
		
		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive(true);
		
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	}*/
	
	
	
	
	
}
