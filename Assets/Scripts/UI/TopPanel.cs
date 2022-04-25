using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TopPanel : MonoBehaviour {

	[SerializeField]
	private LevelState _levelState;
	
	[Header("Distance Left Text")]
	[SerializeField]
	private TextMeshProUGUI _distanceLeftText;

	[SerializeField]
	private Animator _distanceLeftTextAnimator;

	[Header("Lives")]
	[SerializeField]
	private Transform _livesContainer;
	
	private MonsEntity _entity;
	private Image[] _lifeImages;

	void Awake () {
		_entity = GameObject.FindWithTag(Tags.PLAYER).GetComponent<MonsEntity>();
		_lifeImages = _livesContainer.GetComponentsInChildren<Image>();
	}
	
	void Update () {
		DistanceLeftText();
		Lives();
	}

	private void DistanceLeftText () {
		_distanceLeftText.text = $"{_levelState.distanceToFinish:0.0}m to go";

		if (_levelState.hasReachedFinish) {
			_distanceLeftTextAnimator.enabled = true;
		}
	}

	private void Lives () {
		for (int i = 0; i < _lifeImages.Length; i++) {
			_lifeImages[i].color = i < _entity.lives ? Color.red : Color.gray;
		}
	} 

}