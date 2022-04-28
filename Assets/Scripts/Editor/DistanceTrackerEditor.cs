using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DistanceTracker))]
public class DistanceTrackerEditor : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI();

		var script = (DistanceTracker) target;
		
		if (!Application.isPlaying) return;
		
		GUILayout.Label($"Horizontal Distance Travelled: {script.GetHorizontalDistanceTravelled()}");
	}

}