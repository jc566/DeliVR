﻿/************************************************************
 * This script was created by :                             *
 *                                                          *
 ***********************************************************/
using UnityEngine;

using System.Collections;

[RequireComponent(typeof(Collider))]
public class VRInteractable : MonoBehaviour
{
    public GameObject boxBeingHeld; //reference to the box currently held by player

    //saves the original spin speed of an object with the spinScript attached
    public float savedSpinSpeed;

    //Material used when the object is not being gazed at
    public Material inactiveMaterial;

    //Material used when the object is being gazed at
    public Material activeMaterial;

    private Vector3 startingPosition;

    public GameObject boxPlaceHolder; //reference to where the box will be "held"
    public bool isHoldingBox; //reference to know if you are holding a box

    public GameObject player;

    public GameObject redBeltLoc; //reference to the red belt drop off
    public GameObject blueBeltLoc; //reference to the blue belt drop off
    public GameObject greenBeltLoc; //reference to the green belt drop off

    //The amount to scale an object with SizeChangeScript.cs attached
    private const float ScaleAmount = 0.07f;

    void Start()
    {
        //reference to the red belt drop off point
        redBeltLoc = GameObject.Find("redBeltDropOffLocation");
        //reference to the blue belt drop off point
        redBeltLoc = GameObject.Find("blueBeltDropOffLocation");
        //reference to the green belt drop off point
        redBeltLoc = GameObject.Find("greenBeltDropOffLocation");
        player = GameObject.FindGameObjectWithTag("Player");
        //Get the location of the box placeholder
        boxPlaceHolder = GameObject.Find("BoxHolder");
        //startingPosition = transform.localPosition;
        SetGazedAt(false);
    }
    void Update()
    {
        if(isHoldingBox)
        {
            this.transform.LookAt(player.transform);
			this.transform.Rotate (45, 60, 60);

        }
        boxBeingHeld = GameObject.Find("Player").GetComponent<PlayerScripts>().heldBox;
    }

    public void SetGazedAt(bool gazedAt)
    {
        /*if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;*/

        //Debug.Log(gazedAt);
        //printMessage();

    }

    public void Reset()
    {
        //transform.localPosition = startingPosition;
    }

    /********************************************************
    * Function that registers a button click on this box.   * 
    * Functions to hold box will trigger from playerscript. *
    ********************************************************/
    public void pickUpBox()
    {
        isHoldingBox = true;
    }


    /**************************************
      * Functions related to Receiver Belt *
      *************************************/
    public void detectRed()
    {
        //Debug.Log(boxBeingHeld.GetComponent<BoxID>().boxID);
        if (boxBeingHeld.GetComponent<BoxID>().boxID == 1)
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().AddScore();
            boxBeingHeld.SetActive(false);
        }
        else
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().MinusScore();
        }

    }
    public void detectBlue()
    {
        //Debug.Log(boxBeingHeld.GetComponent<BoxID>().boxID);
        if (boxBeingHeld.GetComponent<BoxID>().boxID == 2)
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().AddScore();
            boxBeingHeld.SetActive(false);
        }
        else
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().MinusScore();
        }


    }
    public void detectGreen()
    {
        //Debug.Log(boxBeingHeld.GetComponent<BoxID>().boxID);
        if (boxBeingHeld.GetComponent<BoxID>().boxID == 3)
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().AddScore();
            boxBeingHeld.SetActive(false);
        }
        else
        {
            GameObject.Find("LevelSign").GetComponentInChildren<Canvas>().GetComponentInChildren<changescoretext>().MinusScore();
        }
    }

    public void receiveBox()
    {
        //isHoldingBox = false;
        //GameObject.Find("Player").GetComponent<PlayerScripts>().isHoldingBox = false;
        //receiveTheBox = true;

        //boxBeingHeld.transform.position = redBeltLoc.transform.position;

        boxBeingHeld.SetActive(false);
    }



    //Print a Debug.log message
    public void printMessage()
    {
        //Debug.Log("This is Working");
    }

    public void Recenter()
    {
#if !UNITY_EDITOR
    GvrCardboardHelpers.Recenter();
#else
        GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
        if (emulator == null)
        {
            return;
        }
        emulator.Recenter();
#endif  // !UNITY_EDITOR
    }


}