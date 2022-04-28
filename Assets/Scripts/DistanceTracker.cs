using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour {

	[SerializeField]
	private Vector3 _startPosition;

	public float GetHorizontalDistanceTravelled () {
		Vector3 diff = transform.position - _startPosition;
		diff.y = 0f;

		return diff.magnitude;
	}

}