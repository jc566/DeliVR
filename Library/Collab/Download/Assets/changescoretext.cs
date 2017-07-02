using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changescoretext : MonoBehaviour {

	public Text labelText1;
	public int score;
	public int accuracy;
	public int totalboxes;
    public float time = 20f; 

	// Use this for initialization
	void Start () {	
		score = 0;
		totalboxes = 15;
		UpdateScore ();
		
	}
    void Update()
    {
        updateTimer();
    }
	public void AddScore ()
	{
		score += 1;
		accuracy = score;
		UpdateScore ();
	}

    public void MinusScore()
    {
        score -= 1;
        UpdateScore();
    }
	void UpdateScore() {
		labelText1.text = "Score: " + score + "\r\n" + "Accuracy: " + accuracy + "\r\n" + "Time: " + this.time;		
	}

    void updateTimer()
    {
        //time -= Time.deltaTime;
        this.time = GameObject.Find("GameLogicManager").GetComponentInChildren<Timer>().timecounter;
        UpdateScore();
    }

	void UpdateAccuracy() {
		accuracy = accuracy / totalboxes;
	}
}
