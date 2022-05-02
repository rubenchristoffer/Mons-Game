using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoider : MonoBehaviour, IObstacleAvoider {

	public bool isCollidingWithObstacle => collidingObstacles > 0;

	private int collidingObstacles;
	
	private void OnCollisionEnter (Collision collision) {
		Obstacle obstacle = collision.transform.GetComponentInParent<Obstacle>();
		
		if (obstacle != null && obstacle.enabled) {
			collidingObstacles++;
		}
	}

	private void OnCollisionExit (Collision collision) {
		Obstacle obstacle = collision.transform.GetComponentInParent<Obstacle>();
		
		if (obstacle != null && obstacle.enabled) {
			collidingObstacles--;
		}
	}

}