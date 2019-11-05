using UnityEngine;
using System.Collections;

public class rotate361 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, -360, 0) * Time.deltaTime);
		
	}
}
