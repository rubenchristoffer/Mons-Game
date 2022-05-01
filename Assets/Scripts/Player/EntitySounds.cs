using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySounds : MonoBehaviour {

	[SerializeField]
	private MonsEntity _entity;
	
	[SerializeField]
	private AudioSource _hurtAudio;

	[SerializeField]
	private AudioSource _deathAudio;

	void Awake () {
		_entity.eventOnHurt.AddListener(Entity_OnHurt);
		_entity.eventOnDeath.AddListener(Entity_OnDeath);
	}

	void Entity_OnHurt () {
		_hurtAudio.Play();
	}

	void Entity_OnDeath () {
		_deathAudio.Play();
	}

}
