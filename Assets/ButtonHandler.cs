using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	public GameObject text;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Button1_onclick(){
		Debug.Log ("b1 clicked");
		text.GetComponent<UnityEngine.UI.Text  > ().text  = "TEST 1";
	}

	public void Button2_onclick(){
		Debug.Log ("b2 clicked");
		text.GetComponent<UnityEngine.UI.Text  > ().text  = "TEST 2";
	}
}
