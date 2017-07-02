using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    public float timecounter = 20f;
    public GUIText text;

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {

        timeRunsOut(); 
     
    }

    void timeRunsOut()
    {

        timecounter -= Time.deltaTime;
        if (timecounter <= 0)
        {
            Application.Quit();
        }

        text.text = "time:" + timecounter;
        GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().AddScore();

    }
}
