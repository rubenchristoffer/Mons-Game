using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData")]
public class LevelData : ScriptableObject {

	[SerializeField]
	private float _movementSpeed = 1f;

	[SerializeField]
	private float _finishDistance;

	public float movementSpeed => _movementSpeed;
	public float finishDistance => _finishDistance;

}