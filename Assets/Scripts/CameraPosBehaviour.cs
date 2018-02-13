using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosBehaviour : MonoBehaviour {

	void Start () {
		
		Collider parentCollider = GetComponentInParent<Collider> ();
		Transform parentTransform = GetComponentInParent<Transform> ();
		Vector3 parentBounds = parentCollider.bounds.extents;
		Vector3 parentPosition = parentTransform.position;
		transform.position = new Vector3 (parentPosition.x + parentBounds.x,
			parentPosition.y + parentBounds.y, parentPosition.z + parentBounds.z);
		transform.Rotate (0f, 90.0f, 0f);
	}
	
}
