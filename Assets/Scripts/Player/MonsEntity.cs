using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonsEntity : MonoBehaviour {

	public const int MAX_LIVES = 9;

	public readonly UnityEvent eventOnHurt = new UnityEvent();
	public readonly UnityEvent eventOnDeath = new UnityEvent();

	public int lives { get; private set; }
	public bool isDead { get; private set; }
	
	void Start () {
		lives = MAX_LIVES;
	}

	public void Hurt () {
		if (lives <= 0) return;
		
		lives--;
		eventOnHurt.Invoke();

		if (lives == 0 && !isDead) {
			isDead = true;
			eventOnDeath.Invoke();
		}
	}

}