using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketScript : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Ball") {
			Destroy (other);
		} else if (other.tag == "CueBall") {
			
			other.transform.position = new Vector3 (2.5f, 0.153f, 0.0f);
			other.GetComponent<Rigidbody> ().velocity.Set (0, 0, 0);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
