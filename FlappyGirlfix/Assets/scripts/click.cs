using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {


	public UnityEngine.UI.Text numero;
	public int maito = 0;
	public int maitoclick = 1;
	// Update is called once per frame
	void Update () {
		numero.text = ""+maito;
	}
	

	public void Clicked(){
		
		maito += maitoclick;
		
}
	
	
	
}
