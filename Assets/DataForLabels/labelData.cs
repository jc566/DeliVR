using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class labelData : MonoBehaviour {

	public string[] nameArray = new string[] { "Elmo", "Juan", "Hasan", "Adela", "Jay", "Joe","Judy","John"};
	public string[] zipArray = new string[] { "13839", "34959", "17424", "39503", "39503", "13839", "34959", "17424"};
	public string[] colorArray = new string[] { "Red", "Green", "Blue", "White", "White", "Red", "Green", "Blue"};
	public string[] addressArray = new string[] {"1 Sesame St Hey, Florida","85 UPS Rd	Seoul, Kansas",
		"30 Andy Dr	Woodland Park, New Jersey","1 Roll Rd	Ramapo, New York",
		"1 Ship Rd	Ramapo, New York","1 Orion Way, Florida",
		"85 CIPE Rd	Seoul, Kansas","30 Pack Dr Woodland Park,New Jersey"};

	public Text labelText;
	// Use this for initialization
	void Start () {	
		// int middle = (int)addressArray[0].Length / 2;
		//labelText.text = nameArray[0] + "\r\n" + zipArray[0] + "\r\n" + addressArray[0].Substring(0,12) + 
			//"\r\n" + addressArray[0].Substring(12,addressArray.Length);					
	}

	// Update is called once per frame
	void Update () {

	}
}
