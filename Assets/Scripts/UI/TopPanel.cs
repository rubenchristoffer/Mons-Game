using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopPanel : MonoBehaviour {

	[SerializeField]
	private LevelState _levelState;
	
	[SerializeField]
	private TextMeshProUGUI _distanceLeftText;

	[SerializeField]
	private Animator _distanceLeftTextAnimator;

	void Update () {
		_distanceLeftText.text = $"Distance Left: {_levelState.distanceToFinish:0.0}m";

		if (_levelState.hasReachedFinish) {
			_distanceLeftTextAnimator.enabled = true;
		}
	}

}