using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoider : MonoBehaviour, IObstacleAvoider {

	public bool isCollidingWithObstacle => collidingObstacles > 0;

	private int collidingObstacles;
	
	private void OnCollisionEnter (Collision collision) {
		if (collision.transform.GetComponentInParent<Obstacle>() != null) {
			collidingObstacles++;
		}
	}

	private void OnCollisionExit (Collision collision) {
		if (collision.transform.GetComponentInParent<Obstacle>() != null) {
			collidingObstacles--;
		}
	}

}