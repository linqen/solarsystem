using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

	public float velocity = 1;
	const float reduceVelocitys = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up,velocity/reduceVelocitys*Time.deltaTime);
	}
}
