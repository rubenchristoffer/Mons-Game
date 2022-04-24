using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelState : MonoBehaviour {
	
	public readonly UnityEvent eventFinishedLevel = new UnityEvent();
	
	[SerializeField]
	private DistanceTracker _playerTracker;

	[SerializeField]
	private LevelData _levelData;
	
	public bool hasReachedFinish { get; private set; }

	void Update () {
		if (!hasReachedFinish && _playerTracker.horizontalDistanceTravelled >= _levelData.finishDistance) {
			hasReachedFinish = true;
			eventFinishedLevel.Invoke();
			
			Debug.Log("Cleared Level");
		}
	}
	
}