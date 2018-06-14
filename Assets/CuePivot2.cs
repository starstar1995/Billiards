using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuePivot2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float ry = Input.GetAxis ("Mouse Y");
		gameObject.transform.Rotate (transform.forward, ry);
	}
}
