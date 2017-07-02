using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class GameLogicManager : MonoBehaviour {

   

    public GameObject spawnBoxLocation; //reference to the spawn location

    public List<GameObject> spawnedBoxes; //list to keep track of all the boxes being spawned

    public GameObject new1; //reference to the prefab of the item that needs to be spawned
    public GameObject new2;
    public GameObject new3;
    public GameObject currentBox;

    //GameObject[] boxSizes = new GameObject[3]; 

    public int spawnAmount = 2;

	public Vector3 newRotation = new Vector3(0,45,0);



    // Use this for initialization
    void Start () {

        spawnBoxLocation = GameObject.Find("boxSpawnLocation");
        StartCoroutine(spawnBoxes());
        
    }
	
	// Update is called once per frame
	void Update () {
     
    }
    public IEnumerator spawnBoxes()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            int boxDecide = (int)Random.Range(0f, 3f);
			Debug.Log (boxDecide);
			if (boxDecide == 0)
            {
                currentBox = new1;

            }
            else if (boxDecide == 1)
            {
                currentBox = new2;
            }
			else if (boxDecide == 2){
                currentBox = new3;
            }
            else
            {
                currentBox = new1;
            }

            
			GameObject shippingBoxInstance = Instantiate(currentBox, spawnBoxLocation.transform.position, spawnBoxLocation.transform.rotation) as GameObject;

            spawnedBoxes.Add(shippingBoxInstance);

            yield return new WaitForSeconds(4f);
        }
        

    }


}
