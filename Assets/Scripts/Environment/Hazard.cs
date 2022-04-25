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
			MonsEntity entity = other.GetComponentInParent<MonsEntity>();
			
			if (entity != null) {
				_lastCollisionTime = Time.time;
				
				entity.Hurt();
			}
		}
	}

}