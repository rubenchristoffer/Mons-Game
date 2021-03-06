using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonsEntity : MonoBehaviour {

	public const int MAX_LIVES = 3;
	public const float RESPAWN_HEIGHT = -10f;

	public readonly UnityEvent eventOnHurt = new UnityEvent();
	public readonly UnityEvent eventOnDeath = new UnityEvent();

	[SerializeField]
	private FoodCollectionEvents _foodCollectionEvents;
	
	public int lives { get; private set; } = MAX_LIVES;
	public bool isDead { get; private set; }

	void Awake () {
		_foodCollectionEvents.eventOnFoodCollected.AddListener(FoodCollectionEvents_OnFoodCollected);
	}

	void FoodCollectionEvents_OnFoodCollected (Food food) {
		Heal();
	}
	
	void Update () {
		if (transform.position.y < RESPAWN_HEIGHT) {
			Hurt(lives);
		}
	}

	public void Hurt (int damage = 1) {
		if (isDead) return;
		
		lives -= damage;

		if (lives <= 0 && !isDead) {
			lives = 0;
			isDead = true;
			eventOnDeath.Invoke();
		} else {
			eventOnHurt.Invoke();
		}
	}

	public void Heal () {
		if (lives < MAX_LIVES) lives++;
	}

	public void Respawn (int livesToRespawnWith) {
		lives = livesToRespawnWith;
		isDead = false;
	}

}