using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float f = Input.GetAxis ("Forward");
		float v = Input.GetAxis ("Vertical");
		transform.Translate(new Vector3(v+f*Mathf.Sin((transform.localRotation.eulerAngles.z-90)*Mathf.PI/180),f, h));
		float ry = Input.GetAxis ("Mouse Y");
		float rx = Input.GetAxis ("Mouse X");
		transform.SetPositionAndRotation(
			transform.position,
			Quaternion.Euler( new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rx, transform.eulerAngles.z+ry))
		);

	}
}
