using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueCollision : MonoBehaviour {

	//Rigidbody rb;
	public float power;
	Vector3 oldPos;
	Vector3 vel;
	public GameObject aimDotPF;
	GameObject aimDot;


//	private void OnCollisionEnter(Collision other) {
//		if (other.gameObject.tag == "Ball") {
//			Rigidbody orb = other.gameObject.GetComponent<Rigidbody>();
//			Vector3 d = (other.transform.position - other.contacts[0].point).normalized;
//			Debug.Log (vel);
//			Debug.Log (Vector3.Dot (d, vel));
//
//			orb.AddForce (power*d);
//		}
//	}

//	private void OnTriggerEnter(Collider other) {
//		if (other.gameObject.tag == "Ball") {
//			Rigidbody orb = other.gameObject.GetComponent<Rigidbody> ();
//			Vector3 d = (other.transform.position - transform.parent.position).normalized;
//			orb.AddForce (power * d);
//		}
//	}

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		oldPos = transform.position;
		aimDot = Instantiate (aimDotPF);
		aimDot.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		vel = transform.position - oldPos;
		oldPos = transform.position;


		RaycastHit r;
		if (Physics.Raycast (transform.parent.position, transform.up, out r)) {
			if (r.transform.tag == "CueBall") {
				if (!aimDot.activeSelf)
					aimDot.SetActive (true);
				aimDot.transform.position = r.point;
				
				if (Input.GetButtonDown ("Shoot")) {
					r.rigidbody.AddForce ((r.transform.position - r.point) * power * (r.point - transform.position).magnitude);
				}
			} else {
				if (aimDot.activeSelf) {
					aimDot.SetActive(false);
				}
			}
		} else {
			if (aimDot.activeSelf) {
				aimDot.SetActive(false);
			}
		}

	}
}
