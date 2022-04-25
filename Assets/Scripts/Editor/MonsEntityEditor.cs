using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MonsEntity))]
public class MonsEntityEditor : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI();

		var script = (MonsEntity) target;

		if (!Application.isPlaying) return;
		
		GUILayout.Label($"Lives: {script.lives}");
		GUILayout.Label($"Is Dead: {script.isDead}");

		if (GUILayout.Button("Hurt")) {
			script.Hurt();
		}

		if (GUILayout.Button("Heal")) {
			script.Heal();
		}
	}

}
