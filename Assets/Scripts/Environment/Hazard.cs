using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

	[SerializeField]
	private float _hurtResetTime = 0.5f;
	
	private float _lastCollisionTime;
	
	private void OnTriggerEnter (Collider other) {
		if (Time.time - _lastCollisionTime > _hurtResetTime) {
			_lastCollisionTime = Time.time;
			
			other.GetComponentInParent<MonsEntity>()?.Hurt();
		}
	}

}