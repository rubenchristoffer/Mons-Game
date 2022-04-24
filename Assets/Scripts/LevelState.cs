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
	
	public float distanceToFinish { get; private set; }
	public bool hasReachedFinish { get; private set; }

	void Update () {
		distanceToFinish = _levelData.finishDistance - _playerTracker.horizontalDistanceTravelled;

		if (distanceToFinish < 0) distanceToFinish = 0;
		
		if (!hasReachedFinish && distanceToFinish == 0) {
			hasReachedFinish = true;
			eventFinishedLevel.Invoke();
		}
	}
	
}