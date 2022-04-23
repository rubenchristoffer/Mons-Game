using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	[SerializeField]
	private Rigidbody _rigidbody;
	[SerializeField]
	private LevelData _levelData;

	void FixedUpdate () {
		_rigidbody.velocity = Vector3.right * _levelData.currentSpeed;
	}

}