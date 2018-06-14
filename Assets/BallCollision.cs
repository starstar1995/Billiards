using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

	Rigidbody rb;
	Vector3 op;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Ball" || other.gameObject.tag == "CueBall") {
			Rigidbody orb = other.gameObject.GetComponent<Rigidbody> ();
			Vector3 p = (other.transform.position - transform.position).normalized;
			orb.velocity += Vector3.Dot (rb.velocity, p) * (p);
			Vector3 c = Vector3.Cross (new Vector3 (0.0f, 1.0f, 0.0f), p);
			rb.velocity = c * Vector3.Dot (c, rb.velocity);
		} else if (other.gameObject.tag == "Floor") {
			rb.velocity.Set(0.0f,0.0f,0.0f);
			transform.position = op;
			rb.velocity = new Vector3(0.0f,0.0f,0.0f);
		}
	}

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		op = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
