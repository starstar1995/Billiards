using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCollision : MonoBehaviour {

	public bool longSide;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Ball" || other.gameObject.tag == "CueBall") {
			Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();
			if(longSide)
				rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, -rb.velocity.z); 
			else
				rb.velocity = new Vector3 (-rb.velocity.x, rb.velocity.y, rb.velocity.z); 
		}
	}
}
