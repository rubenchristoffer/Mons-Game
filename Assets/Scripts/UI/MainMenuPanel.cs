using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuPanel : MonoBehaviour {

	public const string LEVEL_SCENE = "Level";

	[SerializeField]
	private TextMeshProUGUI _volumeText;
	
	public void BtnOnPlay () {
		SceneManager.LoadScene(LEVEL_SCENE);
	}

	public void BtnOnQuit () {
		Application.Quit();
	}

	public void SliderOnChangeVolume (float volume) {
		_volumeText.text = $"{volume*100:0}%";

		AudioListener.volume = volume;
	}
	
}