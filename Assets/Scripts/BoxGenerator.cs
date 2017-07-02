using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour {

    public GameObject Box = null;
    public GameObject Box2 = null;
    public GameObject Box3 = null;

    // Use this for initialization
    void Start () {
		for (int x = 0; x < 5; x++)
        {

            SpawnBox(); 
        }
	}
	
    void SpawnBox()
    {
        //random number generator for different box prefabs 
        //cycle through them 
        float x = Random.Range(.01f, .5f);
        float y = Random.Range(.01f, .5f);
        float z = Random.Range(.01f, .5f);
        //Box.transform.localScale += new Vector3(x, y, z);

        GameObject newBox = Instantiate(Box, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject newBox2 = Instantiate(Box2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject newBox3 = Instantiate(Box3, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
