using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	public Transform planetAroundRotate;
	public float rotateAroundVelocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (planetAroundRotate.position, Vector3.up, rotateAroundVelocity * Time.deltaTime);
		transform.Rotate (Vector3.up, -(rotateAroundVelocity * Time.deltaTime));
	}


}
