using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGenerator : MonoBehaviour {


	public objectPooler coinPool;
	
	public float distanceBetweenCoins;

	public void SpawnMilk (Vector3 startPosition)
	{
        
		GameObject coin1 = coinPool.GetPooledObjects();
		coin1.transform.position = startPosition;
		coin1.SetActive(true);
		
		
	}
	
	
}
