using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour {

	private Vector3 _startPosition;

	public float horizontalDistanceTravelled { get; private set; }

	void Start () {
		_startPosition = transform.position;
	}

	void Update () {
		horizontalDistanceTravelled = GetHorizontalDistanceTravelled();
	}

	private float GetHorizontalDistanceTravelled () {
		Vector3 diff = transform.position - _startPosition;
		diff.y = 0f;

		return diff.magnitude;
	}

}