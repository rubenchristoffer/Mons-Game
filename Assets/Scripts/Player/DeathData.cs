using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathData : MonoBehaviour {
	
	public bool respawn { get; set; }
	public int lastCheckpointPlayerLives { get; set; }
	public Vector3 respawnPosition { get; set; }

	public static DeathData I { get; private set; }
	
	void Awake () {
		if (I == null) {
			I = this;
			DontDestroyOnLoad(this);
			SceneManager.sceneLoaded += SceneManager_OnSceneLoaded;
		}

		if (I != this) {
			I.Respawn();
		}
	}

	private void OnDestroy () {
		SceneManager.sceneLoaded -= SceneManager_OnSceneLoaded;
	}

	private void SceneManager_OnSceneLoaded (Scene scene, LoadSceneMode loadSceneMode) {
		if (scene.name.Equals(Scenes.MAIN_MENU)) {
			Destroy(gameObject);
		}
	}

	public void Respawn () {
		if (respawn) {
			MonsEntity entity = FindObjectOfType<MonsEntity>();
			
			entity.Hurt(MonsEntity.MAX_LIVES - lastCheckpointPlayerLives);
			entity.transform.position = respawnPosition;

			CameraMovement cameraMovement = FindObjectOfType<CameraMovement>();

			Vector3 cameraMovementPosition = cameraMovement.transform.position;
			cameraMovementPosition.x = entity.transform.position.x;
			cameraMovement.transform.position = cameraMovementPosition;
		}
	}

}