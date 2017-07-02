using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour {
    public GameObject[] shippingBox; //reference to box being picked up
    public GameObject boxHolder; //reference to where box goes when picked up

    public bool isHoldingBox;//are you holding a box?

    private GameObject heldBox; //reference to the box you are holding right now
	// Use this for initialization
	void Start () {
        //find all game objects with the tag shipping box
        shippingBox = GameObject.FindGameObjectsWithTag("ShippingBox");
        //find the box placeholder object/position
        boxHolder = GameObject.Find("BoxHolder");

     
	}
	
	// Update is called once per frame
	void Update () {
        //first check to see which box you are supposed to hold
        checkBoxListBool();
        //if you are holding a box, then run the function needed when holding a box
		if(isHoldingBox)
        {
            holdingBox(heldBox);
        }
	}
    /********************************************************************************
     * Check which box in the list of boxes you are supposed to beholding.          *
     * Then set your status to HOLDING a BOX                                        *
     * Finally, let the player script know which box you are supposed to be holding *
     *                                                                              *
     * When a player clicks on a box, it is asking to be held.                      *
     * Keep Track of that box. Only one box can ever be held.                       *
     *******************************************************************************/
    public void checkBoxListBool()
    {
        //Sift through the list boxes to pick from
        for(int i = 0; i < shippingBox.Length;i++)
        {
            //if a box is asked to be held, change status to holding box and keep track of which box
            if(shippingBox[i].GetComponent<VRInteractable>().isHoldingBox == true)
            {
                isHoldingBox = true;
                heldBox = shippingBox[i];
            }
        }
    }
    /****************************************************************************************
     * As long as you are holding a box, set the box position to be in the placeholder spot *
     ***************************************************************************************/
    public void holdingBox(GameObject heldBox)
    {
        //Set box position to the placeholder position
        heldBox.transform.position = boxHolder.transform.position;
    }
}
