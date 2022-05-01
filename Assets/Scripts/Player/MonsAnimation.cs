using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsAnimation : MonoBehaviour {

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private MonsEntity _entity;

	void Awake () {
		_entity.eventOnHurt.AddListener(() => {
			_animator.SetTrigger("Hurt");
		});
	}
	
}