using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMovement : MonoBehaviour {

    public float movementSpeed; //movespeed of the box

    public Rigidbody boxRigid; //reference to the boxes rigidbody
	// Use this for initialization
	void Start () {
        //reference this items own rigid body
        boxRigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        //Move the Object with Physics
        boxRigid.MovePosition(transform.position + transform.forward * Time.deltaTime * -1f);
    }
}
