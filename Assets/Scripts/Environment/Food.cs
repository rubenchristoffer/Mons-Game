using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	[SerializeField]
	private GameObject topObject;

	private void OnTriggerEnter (Collider other) {
		FoodCollectionEvents foodCollectionEvents = other.GetComponentInParent<FoodCollectionEvents>();

		if (foodCollectionEvents != null) {
			foodCollectionEvents.eventOnFoodCollected.Invoke(this);

			Destroy(topObject);
		}
	}

}