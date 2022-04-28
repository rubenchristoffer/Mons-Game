using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private Transform _spawnPosition;

	private CameraMovement _camera;
	private DeathData _deathData;
	
	public Vector3 spawnPosition => _spawnPosition.position;

	void Start () {
		_deathData = FindObjectOfType<DeathData>();
	}
	
	private void OnTriggerEnter (Collider other) {
		MonsEntity entity = other.GetComponentInParent<MonsEntity>();
		
		if (entity != null) {
			_deathData.respawn = true;
			_deathData.respawnPosition = spawnPosition;
			_deathData.lastCheckpointPlayerLives = entity.lives;
			
			_animator.SetTrigger("ReachedCheckpoint");
		}
	}

}