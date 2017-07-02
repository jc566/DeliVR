using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changescoretext : MonoBehaviour {

	public Text labelText1;
	public float score;
	public float accuracy;
	public int totalboxes;
    public float time = 20f;


    [SerializeField]
    private string title = "My Window";
    [SerializeField]
    private static float windowWidth = 200f;
    [SerializeField]
    private static float windowHeight = 250f;
    [SerializeField]
    private string text;

    public GUIStyle textStyle;

    private Rect windowRect = new Rect(Screen.width / 2, Screen.height / 2, windowWidth, windowHeight);


    // Use this for initialization
    void Start () {	
		score = 0;
		totalboxes = 15;
		UpdateScore ();
		
	}
    void Update()
    {
        updateTimer();

        //Define the window's position
        windowRect.x = (Screen.width - windowWidth) / 2;
        windowRect.y = (Screen.height - windowHeight) / 2 - Screen.height * 0.3f;
        UpdateAccuracy();
        text = "Accuracy: " + accuracy;
        Debug.Log(accuracy);

    }
	public void AddScore ()
	{
		score += 1;
		
		UpdateScore ();
	}

    public void MinusScore()
    {
        score -= 1;
        UpdateScore();
    }
	void UpdateScore() {
		labelText1.text = "Score: " + score + "\r\n"  + "Time: " + this.time;		
	}

    void updateTimer()
    {
        //time -= Time.deltaTime;
        //this.time = GameObject.Find("GameLogicManager").GetComponentInChildren<Timer>().timecounter;
        UpdateScore();
    }

	void UpdateAccuracy() {
		accuracy = (score / totalboxes) * 100;
        

    }
    void OnGUI()
    {
        
            windowRect = GUI.Window(0, windowRect, DoMyWindow, title);
    }
    void DoMyWindow(int windowID)
    {
        //The component of the window.
        GUI.TextField(new Rect(20, 30, (windowWidth - (0.5f * windowWidth)), (windowHeight - (0.5f * windowHeight))), text, textStyle);
    }
}
