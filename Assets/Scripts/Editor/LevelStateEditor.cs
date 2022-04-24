using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LevelState))]
public class LevelStateEditor : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI();

		var script = (LevelState) target;

		if (!Application.isPlaying) return;
		
		GUILayout.Label($"Distance to finish: {script.distanceToFinish}");
		GUILayout.Label($"Has Reached Finish: {script.hasReachedFinish}");
	}

}