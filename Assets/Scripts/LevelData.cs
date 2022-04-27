using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData")]
public class LevelData : ScriptableObject {

	[SerializeField]
	private float _movementSpeed = 2f;

	[SerializeField]
	private float _finishDistance = 50;

	[SerializeField]
	[Tooltip("Max camera distance before level is considered failed")]
	private float _cameraFailDistance = 6;

	public float movementSpeed => _movementSpeed;
	public float finishDistance => _finishDistance;
	public float cameraFailDistance => _cameraFailDistance;

}