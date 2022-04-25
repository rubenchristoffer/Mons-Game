using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsMovement : MonoBehaviour {

	[SerializeField]
	private Rigidbody _rigidbody;
	[SerializeField]
	private LevelData _levelData;

	[Header("Jumping")]
	[SerializeField]
	private float jumpResetTime = 0.5f;
	[SerializeField]
	private float jumpSpeed = 5f;

	[Header("Ground Detection")]
	[SerializeField]
	private float groundedOffset = 0.2f;
	[SerializeField]
	private float groundedRayLength = 0.25f;
	[SerializeField]
	private LayerMask groundedLayerMask;

	private IInput _input;

	private bool grounded;
	private float jumpTimer;

	private void Awake () {
		_input = GetComponentInParent<IInput>();
	}

	private void FixedUpdate () {
		Vector3 targetVelocity = _rigidbody.velocity;
		
		grounded = Physics.Raycast(transform.position + Vector3.up * groundedOffset, Vector3.down, groundedRayLength, groundedLayerMask);

		if (jumpTimer > 0f) jumpTimer -= Time.fixedDeltaTime;

		targetVelocity.x = _levelData.movementSpeed;

		if (_input.jump && jumpTimer <= 0f && grounded) {
			targetVelocity.y = jumpSpeed;

			jumpTimer = jumpResetTime;
		}

		_rigidbody.velocity = targetVelocity;
	}

}