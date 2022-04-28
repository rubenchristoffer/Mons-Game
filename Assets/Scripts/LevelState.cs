using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class LevelState : MonoBehaviour {

	public readonly UnityEvent eventFinishedLevel = new UnityEvent();
	public readonly UnityEvent eventFailedLevel = new UnityEvent();
	public readonly UnityEvent<Checkpoint> eventReachedCheckpoint = new UnityEvent<Checkpoint>();

	[SerializeField]
	private LevelData _levelData;
	
	private DistanceTracker _playerTracker;
	private MonsEntity _entity;
	private Transform _camera;
	private Checkpoint _checkpoint;

	public float distanceToFinish { get; private set; }
	public bool hasReachedFinish { get; private set; }
	public bool hasFailed { get; private set; }

	public Checkpoint checkpoint {
		get => _checkpoint;
		set {
			_checkpoint = value;
			eventReachedCheckpoint.Invoke(_checkpoint);
		}
	}

	void Awake () {
		_playerTracker = GameObject.FindWithTag(Tags.PLAYER).GetComponent<DistanceTracker>();
		_entity = GameObject.FindWithTag(Tags.PLAYER).GetComponent<MonsEntity>();
		_camera = Camera.main.transform;
	}
	
	void Update () {
		if (hasReachedFinish || hasFailed) return;
		
		distanceToFinish = _levelData.finishDistance - _playerTracker.horizontalDistanceTravelled;

		if (distanceToFinish < 0) distanceToFinish = 0;
		
		if (!hasReachedFinish && distanceToFinish == 0) {
			hasReachedFinish = true;
			eventFinishedLevel.Invoke();
		}

		if (!hasFailed) {
			if (_entity.isDead || Mathf.Abs(_camera.transform.position.x - _entity.transform.position.x) >= _levelData.cameraFailDistance) {
				hasFailed = true;
				eventFailedLevel.Invoke();
			}
		}
	}
	
}