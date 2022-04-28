using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DeathData))]
public class DeathDataEditor : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI();

		var script = (DeathData) target;

		if (!Application.isPlaying) return;
		
		GUILayout.Label($"Respawn: {script.respawn}");
		GUILayout.Label($"Last Checkpoint Player Lives: {script.lastCheckpointPlayerLives}");
		GUILayout.Label($"Respawn position: {script.respawnPosition}");
	}

}