using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;
	
	private float platformWidth;
	
	public float distanceBetweenMin;
	public float distanceBetweenMax;
	
	public GameObject[] thePlatforms;
	private int platformSelector;
	private float[] platformWidths;
	
	public objectPooler[] theObjectPool;
	
	private float minHeight;
	public Transform maxHeightPoint;
	private float maxHeight;
	public float maxHeightChange;
	private float heightChange;
	
	private coinGenerator theCoinGenerator;
	public float randomCoinThreshold;
	
	
	
	
	
	
	
	
	
	public float powerupHeight;
	public objectPooler powerupPool;
	public float powerupThreshold;
	
	
	
	
	
	
	
	
	
	
	// Use this for initialization
	void Start () {
		platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
		
		platformWidths = new float[theObjectPool.Length];
		
		for (int i = 0; i < theObjectPool.Length; i++)
		{
			platformWidths[i] = theObjectPool[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
		}
		
		
		minHeight = transform.position.y;
		maxHeight = maxHeightPoint.position.y;
		
		theCoinGenerator = FindObjectOfType<coinGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < generationPoint.position.x)
		{
			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);
			
			platformSelector = Random.Range(0, theObjectPool.Length);
			
			
			
			heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);
			
			if(heightChange > maxHeight)
			{
				heightChange = maxHeight;
				
			}else if (heightChange < minHeight)
			{
				heightChange = minHeight;
			}
			
			
			if(Random.Range(0f, 100f) < powerupThreshold)
			{
				GameObject pro = powerupPool.GetPooledObjects();
				
				pro.transform.position = transform.position + new Vector3(distanceBetween -1f, Random.Range (powerupHeight /2f, powerupHeight), 0f);
				pro.SetActive(true);
			}
			
			
			
			
			
			transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, heightChange, transform.position.z);
			
			//Instantiate (thePlatform, thePlatforms[platformSelector], transform.position, transform.rotation);
			
			GameObject newPlatform = theObjectPool[platformSelector].GetPooledObjects();
			
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
			
			
			if(Random.Range(0f, 100f) < randomCoinThreshold)
			{
				
			
			theCoinGenerator.SpawnMilk(new Vector3(transform.position.x-7, transform.position.y + 1f, transform.position.z));
			
			}
			transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z);
		}
	}
}
