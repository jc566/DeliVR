using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour {
    float speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag != "ShippingBox")
            return;

        Rigidbody rb = collision.rigidbody;
        rb.velocity = new Vector3(0, 0, (speed*Time.deltaTime));
    }
}
