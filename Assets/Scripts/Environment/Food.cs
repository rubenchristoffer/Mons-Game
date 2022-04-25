using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	[SerializeField]
	private GameObject topObject;
	
	private void OnTriggerEnter (Collider other) {
		MonsEntity entity = other.GetComponentInParent<MonsEntity>();

		if (entity != null) {
			entity.Heal();
			Destroy(topObject);
		}
	}

}