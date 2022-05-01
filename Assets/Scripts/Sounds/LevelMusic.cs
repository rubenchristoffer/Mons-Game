using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour {

	[SerializeField]
	private AudioSource _levelMusic;
	[SerializeField]
	private AudioSource _loseMusic;
	[SerializeField]
	private AudioSource _winMusic;
	
	private LevelState _levelState;

	private void Awake () {
		_levelState = FindObjectOfType<LevelState>();

		_levelState.eventFailedLevel.AddListener(() => {
			_levelMusic.Stop();
			_loseMusic.Play();
		});
		
		_levelState.eventFinishedLevel.AddListener(() => {
			_levelMusic.Stop();
			_winMusic.Play();
		});
	}

	private void Start () {
		_levelMusic.Play();
	}

}