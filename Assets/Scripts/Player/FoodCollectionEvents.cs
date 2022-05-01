using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FoodCollectionEvents : MonoBehaviour {

	public readonly UnityEvent<Food> eventOnFoodCollected = new UnityEvent<Food>();

}