using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	[SerializeField]
	private Animator _animator;
	
	private LevelState _levelState;

	private void Awake () {
		_levelState = FindObjectOfType<LevelState>();
	}

	private void OnTriggerEnter (Collider other) {
		if (other.GetComponentInParent<MonsEntity>() != null) {
			_levelState.checkpoint = this;
			_animator.SetTrigger("ReachedCheckpoint");
		}
	}

}