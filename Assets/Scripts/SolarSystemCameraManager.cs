using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemCameraManager : MonoBehaviour {
	public Camera mainCamera;
	public Transform[] planetsCameraPos;

	private int currentPos=0;
	void Start () {
		mainCamera.transform.position = planetsCameraPos [0].position;
		mainCamera.transform.rotation = planetsCameraPos [0].rotation;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentPos++;
			if (currentPos == planetsCameraPos.Length) {
				currentPos = 0;
			}
		}
		mainCamera.transform.position = planetsCameraPos [currentPos].position;
		mainCamera.transform.rotation = planetsCameraPos [currentPos].rotation;
	}
}
