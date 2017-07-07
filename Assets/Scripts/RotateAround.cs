using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	public Transform planetAroundRotate;
	public float rotateAroundVelocity;
	const float reduceVelocitys = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (planetAroundRotate.position, Vector3.up, rotateAroundVelocity/reduceVelocitys * Time.deltaTime);
		transform.Rotate (Vector3.up, -(rotateAroundVelocity/reduceVelocitys * Time.deltaTime));
	}


}
