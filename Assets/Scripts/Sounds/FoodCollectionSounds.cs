using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollectionSounds : MonoBehaviour {

	[SerializeField]
	private FoodCollectionEvents _foodCollectionEvents;

	[SerializeField]
	private AudioSource[] _foodCollectedSounds;
	
	void Awake () {
		_foodCollectionEvents.eventOnFoodCollected.AddListener((food) => {
			foreach (var foodCollectedSound in _foodCollectedSounds) {
				foodCollectedSound.Play();
			}
		});
	}
	
}