using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour {

	void Awake () {
		FindObjectOfType<LevelState>().eventFinishedLevel.AddListener(LevelState_OnFinishedLevel);
		gameObject.SetActive(false);
	}

	private void OnAnimationFinished () {
		SceneManager.LoadScene(Scenes.MAIN_MENU);
	}
	
	private void LevelState_OnFinishedLevel () {
		gameObject.SetActive(true);
	}
	
}