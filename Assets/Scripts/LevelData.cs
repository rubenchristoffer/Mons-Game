using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData")]
public class LevelData : ScriptableObject {

	[SerializeField]
	private float _currentSpeed = 1f;

	public float currentSpeed => _currentSpeed;

}