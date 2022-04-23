using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	[SerializeField]
	private Transform _followTarget;
	[SerializeField]
	private LevelData _levelData;

	[SerializeField]
	private float _maxFollowSpeed = 2f;

	private IObstacleAvoider _obstacleAvoider;

	private Vector3 _targetPosition;

	void Awake () {
		_obstacleAvoider = _followTarget.GetComponentInParent<IObstacleAvoider>();
	}

	void Update () {
		if (!_obstacleAvoider.isCollidingWithObstacle) {
			_targetPosition = new Vector3(_followTarget.position.x, transform.position.y, transform.position.z);
		} else {
			_targetPosition += Vector3.right*_levelData.currentSpeed * Time.deltaTime;
		}

		transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _maxFollowSpeed * Time.deltaTime);
	}

}