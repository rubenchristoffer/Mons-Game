using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsAnimation : MonoBehaviour {

	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private MonsMovement _movement;

	void Update () {
		_animator.SetBool("isGrounded", _movement.isGrounded);
	}
	
}