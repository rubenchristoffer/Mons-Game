using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour {

	public const string MAIN_MENU_SCENE = "MainMenu";
	
	public void BtnOnRestartLevelPressed () {
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void BtnOnMainMenuPressed () {
		Time.timeScale = 1f;
		SceneManager.LoadScene(MAIN_MENU_SCENE);
	}
	
	void Awake () {
		FindObjectOfType<LevelState>().eventFailedLevel.AddListener(LevelState_OnFailedLevel);
		
		gameObject.SetActive(false);
	}

	void LevelState_OnFailedLevel () {
		gameObject.SetActive(true);
		Time.timeScale = 0f;
	}
	
}